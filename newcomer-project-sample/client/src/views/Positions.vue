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
import { defineComponent } from "vue"
import { Position } from "../models/Position";
import DBUtil from "../utilities/DBUtil";

// type used only to allow defining data types of variables (intellisense)
type NewType = {
    inputText: string;
    positions: Position[];
    posExists: boolean;
}

export default defineComponent({
    name: 'ActualEmployees',
    props: { },
    data(): NewType{
        return{
            inputText: "",
            positions: [],
            posExists: false,
        }
    },
    methods: {
        // posts the position to the positions database
        async postPosition(){
            if(this.inputText.length === 0) return;
            for(var pos of this.positions){
                console.log(pos)
                if (pos.positionName === this.inputText){
                    this.inputText = "";
                    this.posExists = true;
                    return;
                }
            }
            //Configuration - Flip to boot
            this.positions = (await DBUtil.postPosition({id: 0, positionName: this.inputText, numberOfEmployeesOnPos: 0})).data
            this.inputText = ""
        },
        // removes position from the positions database
        async deletePosition(index: number){
            let numOfEmpOnPos = (await DBUtil.getPosition(index)).data
            
            if(numOfEmpOnPos.numberOfEmployeesOnPos === 0){
                this.positions = (await DBUtil.deletePosition(index)).data
            } 
            else{
                console.error("Position cannot be deleted, is not empty: " + numOfEmpOnPos.positionName)
                confirm("Position cannot be deleted because is still in the use!")
            }
        },
    },
    // called on view open
    async mounted(){
        this.positions = (await DBUtil.getPositions()).data
    }
});
</script>

<style>

</style>