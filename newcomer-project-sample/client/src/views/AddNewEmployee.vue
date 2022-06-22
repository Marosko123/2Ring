<template>
    <div class="container mt-0 p-5" style="max-width:60%">
        <h1 class="p-2 mb-5 bg-light text-dark"> Add new employee </h1>
        <div class="bg-image" style="background-image: url('https://img.freepik.com/free-vector/pastel-ombre-background-pink-purple_53876-120750.jpg?w=2000'); height: 100%">
            <table class="table table-bordered align-middle">
                <thead>

                </thead>
                <tbody> 
                    <tr>
                        <td> First name* </td>
                        <td>
                            <div class="d-flex">
                                <input type="text" v-model="employee.firstName" placeholder="First name" class="w-100 form control"/>
                            </div>
                            <h6 v-if="checkFirstName()" :style="{color: ' #f67e7e'}"> Missing first name </h6>
                        </td>
                    </tr>
                    <tr>
                        <td>Last name*</td>
                        <td> 
                            <div class="d-flex">
                                <input type="text" v-model="employee.lastName" placeholder="Last name" class="w-100 form control"/>
                            </div>
                            <h6 v-if="checkLastName()" :style="{color: ' #f67e7e'}"> Missing last name </h6>
                        </td>
                    </tr>
                    <tr>
                        <td>Address</td>
                        <td>
                            <div class="d-flex">
                                <input type="text" v-model="employee.adress" placeholder="Adress" class="w-100 form control"/>
                            </div>
                        </td>
                    </tr>
                    <tr>
                        <td>Birth date*</td>
                        <td>
                            <div class="d-flex">
                                <input type="date" v-model="employee.dateBirth" class="w-100 form control"/>
                            </div>
                            <h6 v-if="checkDateBirth()" :style="{color: ' #f67e7e'}"> Birthday should be in the past </h6>
                        </td>
                    </tr>
                    <tr>
                        <td>Entry date*</td>
                        <td>
                            <div class="d-flex">
                                <input type="date" v-model="employee.dateEntry" class="w-100 form control"/>
                           </div>
                            <h6 v-if="checkDateEntry()" :style="{color: ' #f67e7e'}"> Date should be today or in the past </h6>
                        </td>
                    </tr>
                    <tr>
                        <td>Flat*</td>
                        <td>
                            <div class="d-flex">
                                <input type="number" v-model="employee.flat" placeholder="0" class="w-100 form control"/>
                            </div>
                            <h6 v-if="checkFlat()" :style="{color: ' #f67e7e'}"> Flat must be higher than 0 </h6>
                        </td>
                    </tr>
                    <tr>
                        <td>Position*</td>
                        <td>
                            <label for="positions"></label>
                            <select v-model="employee.position" style="width: 100%" class="selectpicker" id="positions" name="positions" >
                                <option value="" selected></option>
                                <option v-for="position in positions" v-bind:value="position.positionName">
                                    {{position.positionName}}
                                </option>
                            </select>
                            <br>
                            <h6 v-if="checkPosition()" :style="{color: ' #f67e7e'}"> missing </h6>
                        </td>
                    </tr>
                </tbody>
            </table>
        </div>
        <div>
            <button type="button" id="btn" class="btn btn-secondary" @click="submit">Add employee</button>
        </div>
    </div>
</template>

<script lang="ts">

import { defineComponent } from "vue";
import axios from "axios"
import { Position } from "../models/Position";
import { Employee } from "../models/Employee";
import router from "../router";

// type used only to allow defining data types of variables (intellisense)
type NewType = {
    employee: Employee,
    checker: {fName: boolean, lName: boolean, dBirth: boolean, dEntry: boolean, flt: boolean, pos: boolean};
    positions: Position[],
}

export default defineComponent({
    name: 'ActualEmployees',
    props: {
        msg:String,
    },
    data(): NewType{
        return{
            employee: {id: 0,firstName: "", lastName: "", adress: "", dateBirth: "", dateEntry: new Date().toISOString().substr(0, 10), flat: "", position: ""},
            // boolean functions to determine valid input
            checker: {fName: false, lName: false, dBirth: false, dEntry: false, flt: false, pos: false},
            positions: [],
        }
    },
    methods: {
        // on submit button press, checks if input is correct and resets all variables
        submit(){
            if( this.checker.fName || this.checker.lName || this.checker.dBirth 
                || this.checker.dEntry || this.checker.flt || this.checker.pos) {
                console.log("Wrong data inserted")
                return ;
            }
            this.postEmployee()
            router.push({
                name: "EmployeeInfo",
                params: {
                    firstName: this.employee.firstName,
                    lastName: this.employee.lastName,
                    adress: this.employee.adress,
                    dateBirth: this.employee.dateBirth,
                    dateEntry: this.employee.dateEntry,
                    position: this.employee.position,
                    flat: this.employee.flat,
                }
            })
        },
        checkFirstName(){
            return this.checker.fName = this.employee.firstName == ""
        },
        checkLastName(){
            return this.checker.lName = this.employee.lastName == ""
        },
        checkDateBirth(){
            return this.checker.dBirth = (this.employee.dateBirth === "" || new Date() <= new Date(this.employee.dateBirth))
        },
        checkDateEntry(){
            return this.checker.dEntry = (this.employee.dateEntry === "" || new Date().getTime() <= new Date(this.employee.dateEntry).getTime())
        },
        checkFlat(){
            return this.checker.flt =  Number(this.employee.flat) <= 0
        },
        checkPosition(){
            return this.checker.pos = this.employee.position === ""
        },
        // posts employee to the database
        postEmployee(){
            var tmpPositions: Position[]

            // get all existing positions
            axios.get("https://localhost:7283/newwebapi/Positions")
            .then((response)=>{
                console.log(response.data)
                tmpPositions = response.data;
                console.log(tmpPositions)
                
                // if position already exists, increase it
                for(var pos of tmpPositions){
                    console.log("EMPLOYEE POSITION: " + this.employee.position)
                    if(pos.positionName === this.employee.position){
                        pos.numberOfEmployeesOnPos ++;
                        // replace position with increased one
                        axios.put("https://localhost:7283/newwebapi/Positions", {
                            id: pos.id,
                            positionName: pos.positionName,
                            numberOfEmployeesOnPos: pos.numberOfEmployeesOnPos
                        })
                        .then((response)=>{
                            console.log("Increased position: " + response)
                        }).catch((e) => {
                            console.log(e)
                        })
                        break;
                    }
                }
            }).catch((e) => {
                    console.log(e)
            })

            axios.post("https://localhost:7283/newwebapi/Employee", {
                firstName: this.employee.firstName,
                lastName: this.employee.lastName,
                adress: this.employee.adress,
                dateBirth: this.employee.dateBirth,
                dateEntry: this.employee.dateEntry,
                position: (this.employee.position + "_" + this.employee.dateEntry + "_NOEND"),
                flat: this.employee.flat.toString(),
            })
            .then((response)=>{
                console.log(response)
            }).catch((e) => {
                console.log(e)
            })
        },
        // pulls all positions available in the company
        getPositions(){
            axios.get("https://localhost:7283/newwebapi/Positions")
            .then((response)=>{
                this.positions = response.data;
                console.log(response)
            }).catch((e) => {
                    console.log(e)
            })
        },
    },
    mounted(){
        this.getPositions()
    }
})
</script>

<style>

</style>