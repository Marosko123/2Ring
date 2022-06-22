<template>
    <div class="container mt-0 p-5" style="max-width:60%">
        <h1 class="p-2 mb-5 bg-light text-dark">Edit employe</h1>
        <div class="bg-image" style="background-image: url('https://img.freepik.com/free-vector/pastel-ombre-background-pink-purple_53876-120750.jpg?w=2000'); height: 100%">
            <table  class="table table-bordered align-middle">
                <thead>

                </thead>
                <tbody> 
                    <tr>
                        <td>First name*</td>
                        <td>
                            <div class="d-flex">
                                <input type="text" v-model="employee.firstName" class="w-100 form control"/>
                            </div>
                            <h6 v-if="checkFirstName()" :style="{color: ' #f67e7e'}"> Missing first name </h6>
                        </td>
                    </tr>
                    <tr>
                        <td>Last name*</td>
                        <td> 
                            <div class="d-flex">
                                <input type="text" v-model="employee.lastName" class="w-100 form control"/>
                            </div>
                            <h6 v-if="checkLastName()" :style="{color: ' #f67e7e'}"> Missing last name </h6>
                        </td>
                    </tr>
                    <tr>
                        <td>Address</td>
                        <td>
                            <div class="d-flex">
                                <input type="text" v-model="employee.adress" class="w-100 form control"/>
                            </div>
                        </td>
                    </tr>
                    <tr>
                        <td>Date of birth*</td>
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
                                <input type="date" v-model="employee.dateEntry" class="w-100 form control" disabled/>
                            </div>
                            <h6 v-if="checkDateEntry()" :style="{color: ' #f67e7e'}"> Date should be today or in the future disabled </h6>
                        </td>
                    </tr>
                    <tr>
                        <td>Flat*</td>
                        <td>
                            <div class="d-flex">
                                <input type="number" v-model="employee.flat" class="w-100 form control"/>
                            </div>
                            <h6 v-if="checkFlat()" :style="{color: ' #f67e7e'}"> Flat must be higher than 0 </h6>
                        </td>
                    </tr>
                    <tr>
                        <td>Position*</td>
                        <td>
                            <label for="positions"></label>
                            <select v-model="employee.position"  style="width: 100%" class="selectpicker" id="positions" name="positions" >
                                <option value=""></option>
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
        <label v-if="isUpdated"> Updated </label>
        <div>
            <button id="btn" class="btn btn-secondary" type="button" @click="submit">Update employee</button>
        </div>
    
        <div class="mt-5"> <h2 class="p-1 mb-3 bg-light text-dark"> Previous positions </h2> </div>
        <div class="bg-image" style="background-image: url('https://img.freepik.com/free-vector/pastel-ombre-background-pink-purple_53876-120750.jpg?w=2000'); height: 100%">
            <label v-if="prevPosAreEmpty"> No previous positions </label>
            <table v-if="!prevPosAreEmpty" class="table table-bordered align-middle">
                <thead>
                    <td>Position</td>
                    <td>Start</td>
                    <td>End</td>
                </thead>

                <tbody>
                    <tr v-for="(prevPos,key) in previousPositions" >
                        <td>{{prevPos.position}}</td>
                        <td>{{prevPos.dateStart}}</td>
                        <td>{{prevPos.dateEnd}}</td>
                    </tr>
                </tbody>
            </table>
        </div>

    </div>
</template>

<script lang="ts">
import axios from "axios"
import { defineComponent } from "vue"
import { routeLocationKey } from "vue-router";
import { Employee } from "../models/Employee";
import { Position } from "../models/Position";
import { PreviousPosition } from "../models/PreviousPosition";
import router from "../router";

// type used only to allow defining data types of variables (intellisense)
type NewType = {
    employee: Employee,

    isUpdated: boolean;
    checker: {fName: boolean, lName: boolean, dBirth: boolean, dEntry: boolean, flt: boolean, pos: boolean};
    
    storedPosition: string;
    positions: Position[];
    previousPositions: PreviousPosition[];
    prevPosAreEmpty: boolean;
    
    tmpPos: string;
}

export default defineComponent({
    name: 'ActualEmployees',
    props: {
        id: Number,
        firstName: String,
        lastName: String,
        adress: String,
        dateBirth: String,
        dateEntry: String,
        position: String,
        flat: String,
    },
    data(): NewType{
        return{
            employee: {id: 0,firstName: "", lastName: "", adress: "", dateBirth: "", dateEntry: "", flat: "", position: ""},

            isUpdated: false,
            storedPosition: "",
            positions: [],
            previousPositions: [],
            prevPosAreEmpty: true,
            checker: {fName: false, lName: false, dBirth: false, dEntry: false, flt: false, pos: false},

            tmpPos: "",
        }
    },
    methods: {
        // returns true if inputs are correct
        checkValidData(){
            return (this.checker.fName || this.checker.lName || this.checker.dBirth 
                || this.checker.dEntry || this.checker.flt || this.checker.pos)
        },
        // on button click checks if data are valid and sends them to the database where employee is edited
        async submit(){
            if( this.checkValidData()) {
                console.log("Wrong data inserted")
                return ;
            }
            // get previous position 
            var prevPosStored = this.storedPosition.split("|")[this.storedPosition.split("|").length - 1].split("_")[0]
            console.log("PREV POS STORED: " + prevPosStored)

            // end previous and add new position
            if(this.employee.position != prevPosStored){
                var today = new Date();
                var dd = String(today.getDate()).padStart(2, '0');
                var mm = String(today.getMonth() + 1).padStart(2, '0');
                var yyyy = today.getFullYear();
                var now = mm + '/' + dd + '/' + yyyy
    
                this.storedPosition = this.storedPosition.replace("NOEND", now)
                this.storedPosition = this.storedPosition + "|" + this.employee.position + "_" + now + "_" + "NOEND";
               
                try {
                    let response = await axios.get("https://localhost:7283/newwebapi/Positions")
                    var tmpPoses: Position[] = response.data
                    
                    // decrease number of employees on this position
                    for(let loopPos of tmpPoses){
                        if(loopPos.positionName === prevPosStored){
                            loopPos.numberOfEmployeesOnPos--
                            await axios.put("https://localhost:7283/newwebapi/Positions", {
                                id: loopPos.id,
                                positionName: loopPos.positionName,
                                numberOfEmployeesOnPos: loopPos.numberOfEmployeesOnPos,
                            })
                            break
                        }
                    }

                    // increase number of employees on this position
                    for(let loopPos of tmpPoses){
                        if(loopPos.positionName === this.employee.position){
                            loopPos.numberOfEmployeesOnPos++
                            await axios.put("https://localhost:7283/newwebapi/Positions", {
                                id: loopPos.id,
                                positionName: loopPos.positionName,
                                numberOfEmployeesOnPos: loopPos.numberOfEmployeesOnPos,
                            })
                            break
                        }
                    }
                    
                } catch (e) {
                    console.error(e)
                }
            }

            this.editEmployee()
            this.isUpdated = !this.isUpdated
            
            
            router.push({
                name: "EmployeeInfo",
                params: {
                    firstName: this.employee.firstName,
                    lastName: this.employee.lastName,
                    adress: this.employee.adress,
                    dateBirth: this.employee.dateBirth,
                    dateEntry: this.employee.dateEntry,
                    dateLeave: "",
                    position: this.storedPosition,
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
            return false
            return this.checker.dEntry = (this.employee.dateEntry === "" || (new Date() <= new Date(this.employee.dateEntry)))
        },
        checkFlat(){
            return this.checker.flt =  Number(this.employee.flat) <= 0
        },
        checkPosition(){
            return this.checker.pos = this.employee.position === ""
        },
        // edits employee and pushes him into employees database
        editEmployee(){
            axios.put("https://localhost:7283/newwebapi/Employee", {
                id: this.id,
                firstName: this.employee.firstName,
                lastName: this.employee.lastName,
                adress: this.employee.adress,
                dateBirth: this.employee.dateBirth,
                dateEntry: this.employee.dateEntry,
                position: this.storedPosition,
                flat: this.employee.flat.toString(),
            })
            .then((response)=>{
                console.log(response)
            }).catch((e) => {
                    console.log(e)
            })
        },
        // pulls data from the positions database
        getPreviousPositions(){
            axios.get("https://localhost:7283/newwebapi/Positions")
            .then((response)=>{
                this.positions = response.data;
                console.log(response)
            }).catch((e) => {
                    console.log(e)
            })
        },
        // creates an array of previous positions
        splitPreviousPositions(){
            if(this.position)
            if(this.position.split("|").length != 1){
                this.prevPosAreEmpty = false
                var i = 0
                for(var pos of this.position.split("|")){
                    if(i != this.position.split("|").length - 1) {
                        var a = pos.split("_")
                        this.previousPositions.push({position: a[0], dateStart: a[1], dateEnd: a[1]})
                    }           
                    i++
                }
            }
        },
    },
    // called on view open
    mounted(){
        this.storedPosition = String(this.position);
        this.employee.position = String(this.position?.split("|")[this.position?.split("|").length - 1].split("_")[0]);
        this.employee.flat =  String(this.flat);
        this.employee.adress = String(this.adress);
        this.employee.dateEntry = String(this.dateEntry);
        this.employee.dateBirth = String(this.dateBirth);
        this.employee.firstName = String(this.firstName);
        this.employee.lastName = String(this.lastName);
        this.getPreviousPositions()
        this.splitPreviousPositions()
    }
})
</script>

<style>

</style>