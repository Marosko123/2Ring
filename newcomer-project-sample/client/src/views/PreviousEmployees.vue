<template>
    <div class="container mt-0 p-5" style="max-width:60%">
        <h1 class="p-2 mb-5 bg-light text-dark"> Previous employees </h1>     
        <div class="bg-image" style="background-image: url('https://upload.wikimedia.org/wikipedia/commons/thumb/1/1a/Abstract-background-white-12.jpg/2560px-Abstract-background-white-12.jpg'); height: 100%">
            <table class="table table-bordered">
                <thead>
                    <tr class="bg-secondary">
                        <th scope="col">Name</th>
                        <th scope="col">Date of the leaving</th>
                        <th scope="col">Delete</th>
                    </tr>
                </thead>
                <tbody> 
                    <tr v-for="(previousEmployee,index) in previousEmployees" :key="index">
                        <td style="width: 45%">
                            <div id="emp" @click="openPreviousEmployeeInfoView(previousEmployee)" style="cursor: pointer">
                                {{previousEmployee.firstName + " " + previousEmployee.lastName}}
                            </div>
                        </td>
                        <td style="width: 45%">
                            {{previousEmployee.dateEnd}}
                        </td>
                        <td style="width: 10%">
                            <div id="del" @click="deletePreviousEmployee(previousEmployee.id)" style="cursor: pointer">
                                <p class="fa fa-trash pointer"></p>
                            </div>
                        </td>
                    </tr>
                </tbody>
            </table>
        </div>
    </div>
</template>

<script lang="ts">
import { defineComponent } from "vue"
import router from "../router"
import { PreviousEmployee } from "../models/PreviousEmployee"
import DBUtil from "../utilities/DBUtil"

// type used only to allow defining data types of variables (intellisense)
type NewType = {
    previousEmployees: PreviousEmployee[];
}

export default defineComponent({
    name: 'PreviousEmployees',
    props: { },
    data(): NewType{
        return{
            previousEmployees:[],
        }
    },
    methods : {
        // removes previous employee from the previous employees database
        async deletePreviousEmployee(index: number){
            if(confirm("Are you sure you want to delete this employee permanently?")){
                this.previousEmployees = (await DBUtil.deletePreviousEmployee(index)).data
            }
        },
        // opens view where previous employee info is shown
        openPreviousEmployeeInfoView(previousEmployee: PreviousEmployee){
            router.push({
                name: "EmployeeInfo",
                params: {
                    firstName: previousEmployee.firstName,
                    lastName: previousEmployee.lastName,
                    adress: previousEmployee.adress,
                    dateBirth: previousEmployee.dateBirth,
                    dateEntry: previousEmployee.dateEntry,
                    dateLeave: previousEmployee.dateEnd,
                    position: previousEmployee.position,
                    flat: previousEmployee.flat,
                }
            })
        },
    },
    // calls on view open
    async mounted(){
        this.previousEmployees = (await DBUtil.getPreviousEmployees()).data
    }
})
</script>

<style>


</style>