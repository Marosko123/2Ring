<template>
    <div class="container mt-0 p-5" style="max-width:60%">
        <h1 class="p-2 mb-5 bg-light text-dark">Employee info</h1>
        <div class="bg-image" style="background-image: url('https://img.freepik.com/free-vector/pastel-ombre-background-pink-purple_53876-120750.jpg?w=2000'); height: 100%">
            <table class="table table-bordered">
                <thead>

                </thead>
                <tbody> 
                    <tr>
                        <td>First name</td>
                        <td>{{firstName}}</td>
                    </tr>
                    <tr>
                        <td>Last name</td>
                        <td>{{lastName}}</td>
                    </tr>
                    <tr>
                        <td>Address</td>
                        <td>{{adress}}</td>
                    </tr>
                    <tr>
                        <td>Date of birth</td>
                        <td>{{dateBirth}}</td>
                    </tr>
                    <tr>
                        <td>Entry date</td>
                        <td>{{dateEntry}}</td>
                    </tr>
                    <tr v-if='dateLeave != ""'>
                        <td>Leave date</td>
                        <td>{{dateLeave}}</td>
                    </tr>
                    <tr>
                        <td>Flat</td>
                        <td>{{flat}}</td>
                    </tr>
                    <tr>
                        <td>Position</td>
                        <td>{{position?.split("|")[position.split("|").length - 1].split("_")[0]}}</td>
                    </tr>
                </tbody>
            </table>
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
import { defineComponent } from "vue"
import { PreviousPosition } from "../models/PreviousPosition";

// type used only to allow defining data types of variables (intellisense)
type NewType = {
    previousPositions: PreviousPosition[];
    prevPosAreEmpty: boolean;
}

export default defineComponent({
    name: 'EmployeeInfo',
    props: {
        firstName: String,
        lastName: String,
        adress: String,
        dateBirth: String,
        dateEntry: String,
        dateLeave: String,
        position: String,
        flat: String,
    },
    data(): NewType{
        return{
            previousPositions: [],
            prevPosAreEmpty: true,
        }
    },
    methods:{
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
        this.splitPreviousPositions()
    }
});
</script>

<style>
</style>