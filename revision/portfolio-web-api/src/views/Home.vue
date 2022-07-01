<template id="home">
    <!-- Introduction -->
    <section class="intro" id="home">
        <div class="container  bg-light" style="height:100%">
            <h1 class="section__title section__title--intro">
                Hi, I am <br><strong>Maroš Bednár</strong>
            </h1>
            <br>
            <p class="section__subtitle section__subtitle--intro">Full-stack developer</p>
            <br>
            <img src="@/assets/Foto3.jpg" alt="">
        </div>
    </section>

    <!-- My services -->
    <section class="my-services" id="services">
        <div class="container bg-info" style="height:100%">
            <h2 class="section__title section__title--services">What I do</h2>
            <div class="container">
                <div class="row">
                    <div class="col-6">
                        <a href="https://www.doucma.sk/272129-doucovanie-programovanie-je-hracka" target="_blank">Teach</a>
                        <img src="@/assets/teaching.jpg" alt="">
                        <div class="row"><p>with</p></div>
                        <div class="row"><p>with</p></div>
                        <div class="row"><p>with</p></div>
                        <div class="row"><p>with</p></div>
                    </div>
                    <div class="col-6">
                        <a href="https://www.fiit.stuba.sk/" target="_blank">Study</a>
                        <img src="@/assets/studying.jpg" alt="">
                    </div>
                </div>
            </div>
        </div>
    </section>

    <!-- Skills -->
    <section class="my-services" id="services">
        <div class="container bg-warning" style="height:100%">
            <div class="row">
                <h2 class="section__title section__title--services">My skills</h2>
            </div>
                
            <div class="row">
                <div class="col-6 bg-light">
                    <div class="skills__programming">
                        <h3>Programming skills</h3>
                        <div class="container">
                            <div class="row"><p>C/C++</p></div>
                            <div class="row"><p>C#</p></div>
                            <div class="row"><p>Java</p></div>
                            <div class="row"><p>Python</p></div>
                            <div class="row"><p>Html/Css</p></div>
                            <div class="row"><p>Typescript</p></div>
                            <div class="row"><p>Javascript</p></div>
                            <div class="row"><p>SQL</p></div>
                        </div>
                    </div>
                </div>

                <div class="col-6 bg-success">
                    <div class="skills__programming">
                        <h3>Frameworks skills</h3>
                        <div class="container">
                            <div class="row"><p>Vue js</p></div>
                            <div class="row"><p>Bootstrap</p></div>
                            <div class="row"><p>Spring</p></div>
                            <div class="row"><p>Swing</p></div>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </section>

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

<!--style>

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

section{
    height: 800px;
}

</style-->