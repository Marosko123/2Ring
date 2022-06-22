<template>
    <div class="container mt-0 p-5" style="max-width:60%">
        <h1 class="p-2 mb-5 bg-light text-dark"> Positions </h1>
        <div class="bg-image" style="background-image: url('https://img.freepik.com/free-vector/pastel-watercolor-painted-background_23-2148959638.jpg?w=2000'); height: 100%">
            <table class="table table-bordered align-middle">
                <thead>
                    <tr class="bg-secondary">
                        <th scope="col">Position</th>
                        <th scope="col">Delete</th>
                    </tr>
                </thead>
                <tbody> 
                    <tr v-for="(position,index) in positions" :key="position.id">
                        <td style="width: 40%">
                            {{position.positionName}}
                        </td>
                        <td id="del" style="width: 10%">
                            <div @click="deletePosition(position.id)" style="cursor: pointer">
                                <p class="fa fa-trash pointer"></p>
                            </div>
                        </td>
                    </tr>
                </tbody>
            </table>
        </div>
        <div class="d-flex mt-3">
            <input type="inputText" v-model="inputText" placeholder="Position to add" class="w-100 form control" @click="posExists=false"/>
            <button class="btn btn-secondary rounded-0" @click="postPosition" id="btn" type="button" aria-label="Left Align"> Add </button>
        </div>
        <h6 v-if="posExists" :style="{color: ' #f67e7e'}"> Position already exists </h6>
    </div>
</template>

<script lang="ts">
import axios from "axios";
import { emitWarning } from "process";
import { defineComponent } from "vue"
import { Position } from "../models/Position";

// type used only to allow defining data types of variables (intellisense)
type NewType = {
    inputText: string;
    positions: Position[];
    posExists: boolean;
}

export default defineComponent({
    name: 'ActualEmployees',
    props: {
        msg:String,
    },
    data(): NewType{
        return{
            inputText: "",
            positions: [],
            posExists: false,
        }
    },
    methods: {
        // posts the position to the positions database
        postPosition(){
            if(this.inputText.length === 0) return;
            for(var pos of this.positions){
                console.log(pos)
                if (pos.positionName === this.inputText){
                    this.inputText = "";
                    this.posExists = true;
                    return;
                }
            }
            
            // posts the position to the positions database
            axios.post("https://localhost:7283/newwebapi/Positions", {
                positionName: this.inputText,
                numberOfEmployeesOnPos: 0
            })
            .then((response)=>{
                this.positions = response.data;
                console.log(response)
            }).catch((e) => {
                console.log(e)
            })
            this.inputText = ""
        },
        // removes position from the positions database
        deletePosition(index: number){
            axios.get("https://localhost:7283/newwebapi/Positions/" + index)
            .then((response)=>{
                if(!response.data.numberOfEmployeesOnPos){
                    console.log("Position is empty: " + response.data.positionName)

                    axios.delete("https://localhost:7283/newwebapi/Positions/" + index)
                    .then((response)=>{
                        this.positions = response.data;
                        console.log(response)
                    }).catch((e) => {
                        console.log(e)
                    })  
                } 
                else{
                    console.log("Position cannot be deleted, is not empty: " + response.data.positionName)
                    confirm("Position cannot be deleted because is still in the use!")
                }
            }).catch((e) => {
                    console.log(e)
            })
        },
        // pulls positions from the positions database
        getPositions(){
            axios.get("https://localhost:7283/newwebapi/Positions")
            .then((response)=>{
                console.log(response)
                this.positions = response.data;
            }).catch((e) => {
                    console.log(e)
            })
        },
    },
    // called on view open
    mounted(){
        this.getPositions()
    }
});
</script>

<style>

</style>