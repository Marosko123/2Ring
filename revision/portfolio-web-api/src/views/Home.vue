<template id="collection">
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
                Hi, I am <strong>Maroš Bednár</strong>
            </h1>
            <p class="section__subtitle section__subtitle--intro">Full-stack developer</p>
            <img src="@/assets/Foto.jpg" alt="A picture of Maros Bednar" class="intro__img">
        </section>

        <!-- My services -->
        <section class="my-services" id="services">
            <h2 class="section__title section__title--services">What I do</h2>
            <p class="section__subtitle section__subtitle--services"></p>
            
            <div class="services">
                <div class="service">
                    <h3 class="service__name">Teaching</h3>
                    <p>
                        Teaching is a very good tool to revise all what 
                        we have learned during our carreer. Also, it helps 
                        others to progress faster with the same effort. 
                        Furthermore, during lessons we are making new friends, 
                        solving different problems and so on... 😊  
                    </p>
                    <p>
                        Among the programming languages I love to teach belong 
                        C/C++, C#, Java, Python, Html/Css and Javascript. 
                        Also, I love to create games in game engine Unity, so 
                        this is also one of the topics that I teach... 😊
                    </p>
                    <p>
                        If you would like to have lessons with me, feel free to 
                        contact me! 
                    </p>
                </div>
                <div class="service">
                    <h3 class="service__name">Programming</h3>
                    <p>
                        Do you need a website? 
                    </p>
                    <p> 
                        I can make you one! Send me an email 
                        containing all necessary information and as soon as I go 
                        through your criteria I will write you back... 😉
                    </p>
                    <br> 
                    <p>
                        Do you need a specialised application? 
                    </p>
                    <p> 
                        You are on a right place! Send me an email 
                        containing all necessary information and as soon as I go 
                        through your criteria I will write you back... 😉
                    </p>
                </div>
            </div>

            <a href="mailto:bednarmaros341@gmail.com" class="btn">SEND ME AN EMAIL!</a>
        </section>

        <!-- About me -->
        <section class="about-me" id="about">
            <h2 class="section__title section__title--about">Who I am</h2>
            <p class="section__subtitle section__subtitle--about">Full-stack developer based inside Slovakia</p>

            <div class="about-me__body">
                <p>
                    I am a 20-years old student of the Faculty of Informatics 
                    and Information Technologies Bratislava who love to improve on 
                    a daily basis. 📈 
                </p>
                <br>
                <p>
                    Also, I love sports. I was a very active kid in my childhood and 
                    a part of activness stood inside me till today. This days I play 
                    volleyball or basketball, go snowboarding during the winter season, 
                    go cycling in the summer or even go fishing. 🎣
                </p>
                <br>
                <p>
                    Maybe you are asking me, "How did you learn programming?". The answer 
                    is a little bit funny. As a kid I dreamed to be a doctor. Be famous, 
                    have a lot people who need me. I also chose a school to prepare for 
                    being a doctor. It was a grammar school. We had a lot of biology and 
                    chemistry. These subjects were one of my favourite.  

                </p>
            </div>

            <img src="@/assets/Foto3.jpg" alt="Maros idk.." class="about-me__img">
        </section>

        <!-- My Work -->
        <section class="my-work" id="work">
            <h2 class="section__title section__title--work">My work</h2>
            <p class="section__subtitle section__subtitle--work">Selection of my work</p>

            <div class="portfolio">
                <router-link to="/projectStorageUnitAuction" id="router" class="portfolio__item" aria-current="page">  
                    <img src="@/assets/storageUnitAuction_picture.jpg" alt="storage unit auction" class="portfolio__img">
                </router-link>
                <router-link to="/projectDataStructures" id="router" class="portfolio__item" aria-current="page">  
                    <img src="@/assets/dataStructures_image.png" alt="data structures" class="portfolio__img">
                </router-link>
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
    name: 'Collection',
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