<template id="projectDataStructures">
    <head>
        <meta charset="UTF-8">
        <meta name="viewport" content="width=device-width, initial-scale=1.0">
        <title>DevMaros Portfolio</title>
        <link rel="preconnect" href="https://fonts.googleapis.com">
        <link rel="preconnect" href="https://fonts.gstatic.com">
        <link href="https://fonts.googleapis.com/css2?family=Gentium+Book+Plus&family=Source+Sans+Pro:wght@200&display=swap" rel="stylesheet">
    </head>

    <body>
        <!-- Introduction -->
        <section class="intro" id="home">
            <h1 class="section__title section__title--intro">
                <strong>Data Structures</strong>
            </h1>
            <p class="section__subtitle section__subtitle--intro">Created in C language ☠️☠️☠️</p>
            <img src="@/assets/dataStructures_image.png" alt="A picture of the data structures project" class="intro__img">
        </section>

        <!-- My services -->
        <section class="my-services" id="services">
            <h2 class="section__title section__title--services">What have I coded</h2>
            <p class="section__subtitle section__subtitle--services"></p>
            
            <div class="services">
                <div class="service">
                    <h3 class="service__name">Hash tables</h3>
                    <p>
                        Easy to code
                    </p>
                    <p>
                        Fast
                    </p>
                    <p>

                    </p>
                </div>
                <div class="service">
                    <h3 class="service__name">Binary trees</h3>
                    <p>
                        AVL-Tree
                    </p>
                    <p> 
                        Fast, 2 children
                    </p>
                    <br> 
                    <p>
                        Red-black tree
                    </p>
                    <p> 
                        Bullshit :D
                    </p>
                </div>
            </div>
        </section>

        <!-- Footer -->
        <footer class="footer">
            <ul class="social-list">
                <li class="social-list__item"><a class="social-list__link" href="mailto:bednarmaros341@gmail.com" target="_blank"><img class="footer__logo" src="@/assets/gmailLogo.png" alt="Gmail logo"></a></li>
                <li class="social-list__item"><a class="social-list__link" href="https://github.com/Marosko123" target="_blank"><img class="footer__logo" src="@/assets/githubLogo.png" alt="Github logo"></a></li>
                <li class="social-list__item"><a class="social-list__link" href="https://www.linkedin.com/in/marosbednar/" target="_blank"><img class="footer__logo" src="@/assets/linkedInLogo.png" alt="Linkedin logo"></a></li>
                <li class="social-list__item"><a class="social-list__link" href="https://www.instagram.com/bednar.maros/" target="_blank"><img class="footer__logo" src="@/assets/instagramLogo.png" alt="Instagram logo"></a></li>
                <li class="social-list__item"><a class="social-list__link" href="https://www.facebook.com/maros.bednar8/" target="_blank"><img class="footer__logo" src="@/assets/facebookLogo.png" alt="Facebook logo"></a></li>
                <li class="social-list__item"><a class="social-list__link" href="https://www.doucma.sk/272129-doucovanie-programovanie-je-hracka" target="_blank"><img class="footer__logo" src="@/assets/doucmaLogo.png" alt="Doucma logo"></a></li>
            </ul>   
        </footer>
    </body>
</template>

<script lang="ts">
import { defineComponent } from "vue"

export default defineComponent ({
    name: 'projectDataStructures',
    props: {

    },
    data() {
        return {

        }
    },
    methods:{

    },
    mounted(){
        
    }
})
</script>

<style>
@import '@/styles/style.css';


</style>