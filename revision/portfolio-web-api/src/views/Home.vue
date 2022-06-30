<template id="home">
    
</template>

<script lang="ts">
import { defineComponent } from "vue"

export default defineComponent ({
    name: 'Home',
    props: {

    },
    data() {
        return {
            clicks: 0,
            text: "",
            isAwesome: true
        }
    },
    methods:{
        submit(){
            this.text = "";
        },
    },
    mounted(){

    }
})
</script>

<style>

h1{
    display: inline;
    line-height: 1em;
}

.my-text{
    margin-top: 75px;
    color: rgb(28, 31, 74);
    background-color: aliceblue;
    text-align: start;
    border-radius: 35px;
    width: 950px;
    margin-left: 50px;
}

.my-first-text,
.my-text-hover:hover{
    color: rgb(0, 153, 255);
    font-size: 60px;
}

.user-text{
    margin-top: 75px;
    margin-right: 50px;
    color: rgb(28, 31, 74);
    background-color: aliceblue;
    text-align: end;
    border-radius: 35px;
    width: 950px;
}

.user-first-text,
.user-text-hover:hover{
    color: rgb(255, 74, 74);
    font-size: 60px;
}

.anchor{
    font-size: 60px;
}

</style>