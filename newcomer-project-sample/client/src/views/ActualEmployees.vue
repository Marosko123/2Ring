<template>
    <div class="container mt-0 p-5" :key="componentKey" style="max-width:60%">
        <h1 class="p-2 mb-5 bg-light text-dark" >Actual employees</h1>
        <div class="bg-image" style="background-image: url('https://images.pexels.com/photos/1631677/pexels-photo-1631677.jpeg?cs=srgb&dl=pexels-abdullah-ghatasheh-1631677.jpg&fm=jpg'); height: 100%">
            <table class="table table-bordered align-middle">
                <thead>
                    <tr class="bg-secondary">
                        <th scope="col">Name</th>
                        <th scope="col">Position</th>
                        <th scope="col">Edit</th>
                        <th scope="col">Delete</th>
                    </tr>
                </thead>
                <tbody> 
                    <tr v-for="(emp,key) in employees" :key="emp.id">
                        <td style="width: 40%">
                            <div id="emp" @click="openShowEmployeeInfoView(emp)" style="cursor: pointer">
                                {{emp.firstName + " " + emp.lastName}}
                            </div>
                        </td>
                        <td style="width: 40%">{{getLastPosition(emp.position)}}</td>
                        <td style="width: 10%">
                            <button id="edit" type="button" class="btn btn-light mr-1" data-bs-toggle="modal" data-bs-target="#exampleModal" @click="openEditEmployeeView(emp)">
                                <div @click="openEditEmployeeView(emp)" style="cursor: pointer">
                                    <p class="fa fa-pen pointer"></p>
                                </div>
                            </button>
                        </td>
                        <td style="width: 10%">
                            <div id="del" @click="deleteEmployee(emp)" style="cursor: pointer">
                                <p class="fa fa-trash pointer"></p>
                            </div>
                        </td>
                    </tr>
                </tbody>
            </table>
        </div>
        <div>
            <button type="button" id="btn" class="btn btn-secondary"  @click="openAddEmployeeView">Add new Employee </button>
        </div>
    </div>
</template>

<script lang="ts">

import { defineComponent } from "vue"
import router from "../router";
import { Employee } from "../models/Employee";
import { Position } from "../models/Position";
import DBUtil from "../utilities/DBUtil";
// type used only to allow defining data types of variables (intellisense)
type NewType = {
    showModal: boolean;
    inputText: string;
    positions: Position[];
    employees: Employee[];
    componentKey: number;
};

export default defineComponent({
    name: 'ActualEmployees',
    props: {    },
    data(): NewType{
        return{
            showModal: false,
            inputText: "",
            positions: [],
            employees: [],
            componentKey: 0,
        }
    },
    methods: {
        // opens view where employee's info is shown
        openShowEmployeeInfoView(emp: Employee){
            router.push({
                name: "EmployeeInfo",
                params: {
                    firstName: emp.firstName,
                    lastName: emp.lastName,
                    adress: emp.adress,
                    dateBirth: emp.dateBirth,
                    dateEntry: emp.dateEntry,
                    dateLeave: "",
                    position: emp.position,
                    flat: emp.flat,
                }
            })
        },
        // opens view where programe adds new employee
        openAddEmployeeView(){
            router.push("AddNewEmployee")
        },
        // opens view where employee is being editted
        openEditEmployeeView(emp: Employee){
            router.push({
                name: "EditEmployee",
                params: {
                    id: emp.id,
                    firstName: emp.firstName,
                    lastName: emp.lastName,
                    adress: emp.adress,
                    dateBirth: emp.dateBirth,
                    dateEntry: emp.dateEntry,
                    position: emp.position,
                    flat: emp.flat,
                }
            })
        },
        // delete employee from actual employees database
        async deleteEmployee(emp: Employee){
            if(confirm("Do you really want to delete this employee?"))
            {
                // archive the employee to previous employees database
                if(confirm("Do you want to archive this employee?")){
                    var dateFormat = new Date().toLocaleDateString("en-US");
            
                    DBUtil.postPreviousEmployee({
                        id: 0,
                        firstName: emp.firstName,
                        lastName: emp.lastName,
                        adress: emp.adress,
                        dateBirth: emp.dateBirth,
                        dateEntry: emp.dateEntry,
                        dateEnd: dateFormat,
                        position: emp.position,
                        flat: emp.flat,
                    }) 
                }
                var tmpPos = this.getLastPosition(emp.position)

                // delete employee from actual employees database
                this.employees = (await DBUtil.deleteEmployee(emp.id)).data
                this.positions = (await DBUtil.getPositions()).data

                for(var pos of this.positions){
                    if(pos.positionName === tmpPos){
                        pos.numberOfEmployeesOnPos--
                        DBUtil.putPosition({
                            id: pos.id,
                            positionName: pos.positionName,
                            numberOfEmployeesOnPos: pos.numberOfEmployeesOnPos
                        })
                        break;
                    }
                }
            }
        },
        // returns the last position from the format "POSITION_DATE-ENTRY_DATE-LEAVE | POSITION_DATE-ENTRY_DATE-LEAVE | ..."
        getLastPosition(positionsString: string){
            return positionsString.split("|")[positionsString.split("|").length - 1].split("_")[0]
        }
    },
    // function called on view open
    async mounted(){
        this.employees = (await DBUtil.getEmployees()).data
    },
})


</script>

<style>
#emp:hover{
    color:rgb(15, 202, 128);
}
#del:hover{
    color: rgb(255, 4, 4);
}
#edit:hover{
    color: gold;
}
#btn{
    font-size: 27px;
}
#btn:hover{
    color: rgb(0, 0, 0)
}

</style>