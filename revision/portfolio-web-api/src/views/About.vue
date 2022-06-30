<template id="about">
    <div>
        <div class="container my-text">
            <h1 class="anchor"> </h1>
            <h1 class="my-first-text">Hi!</h1>
            <br>
            <h1 class="anchor"> </h1>
            <h1 class="my-text-hover">My </h1> 
            <h1 class="my-text-hover">name </h1> 
            <h1 class="my-text-hover">is </h1> 
            <h1 class="my-text-hover">Maroš. </h1> 
            <br>
            <h1 class="anchor"> </h1>
            <h1 class="my-text-hover">How </h1>
            <h1 class="my-text-hover">can </h1>
            <h1 class="my-text-hover">I </h1>
            <h1 class="my-text-hover">help </h1>
            <h1 class="my-text-hover">you</h1>
            <h1 class="my-text-hover">?</h1>
            <br>
            <br>
        </div>

        <div class="container user-text">
            <h1 class="anchor"> </h1>
            <h1 class="user-first-text"> How </h1>
            <h1 class="user-text-hover"> can </h1>
            <h1 class="user-text-hover"> I </h1>
            <h1 class="user-text-hover"> reach </h1>
            <h1 class="user-text-hover">you</h1>
            <h1 class="user-text-hover">?</h1>
            <br>    
            <br>    
        </div>

        <div class="container my-text">
            <h1 class="anchor"> </h1>
            <h1 class="my-first-text"> Send </h1>
            <h1 class="my-text-hover"> me </h1>
            <h1 class="my-text-hover"> an </h1>
            <h1 class="my-text-hover"> email </h1>
            <h1 class="my-text-hover"> ;)  </h1>
            <div class="container pt-3">
                <form>
                    <div class="form-row">
                        <label for="inputFirstName">First name</label>
                        <div class="col col-md-12">
                            <input v-if="validFirstName" id="inputFirstNameV" type="text" v-model="email.firstName" class="form-control validFirstName" placeholder="First name">
                            <input v-else type="text" id="inputFirstNameI" v-model="email.firstName" class="form-control invalidFirstName" placeholder="First name">
                        </div>
                        <label for="inputLastName">Last name</label>
                        <div class="col col-md-12">
                            <input v-if="validLastName" id="inputLastNameV" type="text" v-model="email.lastName" class="form-control validFirstName" placeholder="Last name">
                            <input v-else type="text" id="inputLastNameI" v-model="email.lastName" class="form-control invalidLastName" placeholder="Last name">
                        </div>
                    </div>
                    <div class="form-row">
                        <div class="form-group col-md-12">
                            <label for="inputEmail4">Email</label>
                            <input v-if="validEmail" type="email" v-model="email.email" class="form-control validEmail" id="inputEmail4" placeholder="Email">
                            <input v-else type="email" v-model="email.email" class="form-control invalidEmail" id="inputEmail4" placeholder="Email">
                        </div>
                    </div>
                    <div class="form-row">
                        <div class="form-group col-md-12">
                            <label for="inputTelNum">Tel. num</label>
                            <input v-if="validEmail" type="tel" v-model="email.telNum" class="form-control validEmail" id="inputTelNum" placeholder="ex. +427 856 421 123">
                            <input v-else type="tel" v-model="email.telNum" class="form-control invalidEmail" id="inputTelNum" placeholder="ex. +427 856 421 123">
                        </div>
                    </div>
                    <div class="form-row">
                        <label for="inputMsg">Message</label>
                        <div class="form-group col-md-12">
                            <textarea type="text" rows="5" v-model="email.msg" class="form-control" id="inputMsg" placeholder="What message do you want to send me? :)"/>
                        </div>
                    </div>
                    <div class="form-row">
                        <label for="exampleFormControlFile1">Example file input</label>
                        <div class="form-group col-md-12">
                            <input type="file" class="form-control-file" id="exampleFormControlFile1">
                        </div>
                    </div>
                    <button type="button" class="btn btn-primary mt-3" @click="validateEmail()"> Send </button>
                </form>
            </div>
        </div>
    </div>
</template>


<script lang="ts">
import { defineComponent } from "vue"
import type { Email } from "../models/Email"

type NewType = {
    email: Email;
    validFirstName: boolean;
    validLastName: boolean;
    validEmail: boolean;
    validTelNum: boolean;
}

export default defineComponent ({
    name: 'About',
    props: {

    },
    data(): NewType{
        return {
            email: {firstName: "", lastName: "", email: "", telNum: "", msg: ""},
            validFirstName: false,
            validLastName: false,
            validEmail: false,
            validTelNum: false,
        }
    },
    methods:{
        validateEmail(){
            if(this.validFirstName && this.validLastName && this.validEmail && this.validTelNum)
            {
                console.log("Sending correct email: ")
                console.log(this.email)
                this.email = {firstName: "", lastName: "", email: "", telNum: "", msg: ""}
            }
            console.error("invalid email form data")
        },
    },
    mounted(){
        
    },
    updated(){
        if(this.email.firstName.length != 0) {
            this.validFirstName = true
            document.getElementById("inputFirstNameV")?.focus()
        }
        else{
            this.validFirstName = false
            document.getElementById("inputFirstNameI")?.focus()
        }
        /*
        if(this.email.lastName.length != 0) {
            this.validLastName = true
            document.getElementById("inputLastNameV")?.focus()
        }
        else{
            this.validLastName = false
            document.getElementById("inputLastNameI")?.focus()
        } */
    }
})


</script>



<style>
.invalidFirstName,
.invalidLastName,
.invalidEmail,
.invalidTelNum{
    border-color: red;
}

.validFirstName,
.validLastName,
.validEmail,
.validTelNum{
    border-color: green;
}
</style>