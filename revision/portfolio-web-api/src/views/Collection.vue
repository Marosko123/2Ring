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
        <header>
            <div class="logo">
                <img src="@/assets/Foto3.jpg" alt="A picture of Me">
            </div>
            <button class="nav-toggle" aria-label="toggle navigation">
                <span class="hamburger">a</span>
            </button>
            <nav class="nav">
                <ul class="nav__list">
                    <li class="nav__item"><a href="#home" class="nav__link">Home</a></li>
                    <li class="nav__item"><a href="#services" class="nav__link">My Services</a></li>
                    <li class="nav__item"><a href="#about" class="nav__link">About me</a></li>
                    <li class="nav__item"><a href="#work" class="nav__link">My work</a></li>
                </ul>
            </nav>
        </header>

        <!-- Introduction -->
        <section class="intro" id="home">
            <h1 class="section__title section__title--intro">
                Hi, I am <strong>Maroš Bednár</strong>
            </h1>
            <p class="section__subtitle section__subtitle--intro">front-end dev</p>
            <img src="@/assets/Foto.jpg" alt="A picture of Maros Bednar" class="intro__img">
        </section>

        <!-- My services -->
        <section class="my-services" id="services">
            <h2 class="section__title section__title--services">What I do</h2>
            <p class="section__subtitle section__subtitle--services"></p>
            
            <div class="services">
                <div class="service">
                    <h3>Teach</h3>
                    <p>Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book. It has survived not only five centuries, but also the leap into electronic typesetting, remaining essentially unchanged. It was popularised in the 1960s with the release of Letraset sheets containing Lorem Ipsum passages, and more recently with desktop publishing software like Aldus PageMaker including versions of Lorem Ipsum</p>
                </div>
                <div class="service">
                    <h3>Study</h3>
                    <p>It is a long established fact that a reader will be distracted by the readable content of a page when looking at its layout. The point of using Lorem Ipsum is that it has a more-or-less normal distribution of letters, as opposed to using 'Content here, content here', making it look like readable English. Many desktop publishing packages and web page editors now use Lorem Ipsum as their default model text, and a search for 'lorem ipsum' will uncover many web sites still in their infancy. Various versions have evolved over the years, sometimes by accident, sometimes on purpose (injected humour and the like).</p>
                </div>
                <div class="service">
                    <h3>Work</h3>
                    <p>Contrary to popular belief, Lorem Ipsum is not simply random text. It has roots in a piece of classical Latin literature from 45 BC, making it over 2000 years old. Richard McClintock, a Latin professor at Hampden-Sydney College in Virginia, looked up one of the more obscure Latin words, consectetur, from a Lorem Ipsum passage, and going through the cites of the word in classical literature, discovered the undoubtable source. Lorem Ipsum comes from sections 1.10.32 and 1.10.33 of "de Finibus Bonorum et Malorum" (The Extremes of Good and Evil) by Cicero, written in 45 BC. This book is a treatise on the theory of ethics, very popular during the Renaissance. The first line of Lorem Ipsum, "Lorem ipsum dolor sit amet..", comes from a line in section 1.10.32.</p>
                </div>
            </div>

            <a href="#work" class="btn">My Work</a>
        </section>

        <!-- About me -->
        <section class="about-me" id="about">
            <h2 class="section__title section__title--about">Who I am</h2>
            <p class="section__subtitle section__subtitle--about">Full-stack developer based inside Slovakia</p>

            <div class="about-me__body">
                <p>There are many variations of passages of Lorem Ipsum available, but the majority have suffered alteration in some form, by injected humour, or randomised words which don't look even slightly believable. If you are going to use a passage of Lorem Ipsum, you need to be sure there isn't anything embarrassing hidden in the middle of text. All the Lorem Ipsum generators on the Internet tend to repeat predefined chunks as necessary, making this the first true generator on the Internet. It uses a dictionary of over 200 Latin words, combined with a handful of model sentence structures, to generate Lorem Ipsum which looks reasonable. The generated Lorem Ipsum is therefore always free from repetition, injected humour, or non-characteristic words etc.</p>
                <p>There are many variations of passages of Lorem Ipsum available, but the majority have suffered alteration in some form, by injected humour, or randomised words which don't look even slightly believable. If you are going to use a passage of Lorem Ipsum, you need to be sure there isn't anything embarrassing hidden in the middle of text. All the Lorem Ipsum generators on the Internet tend to repeat predefined chunks as necessary, making this the first true generator on the Internet. It uses a dictionary of over 200 Latin words, combined with a handful of model sentence structures, to generate Lorem Ipsum which looks reasonable. The generated Lorem Ipsum is therefore always free from repetition, injected humour, or non-characteristic words etc.</p>
            </div>

            <img src="@/assets/Foto3.jpg" alt="Maros idk.." class="about-me__img">
        </section>

        <!-- My Work -->
        <section class="my-work" id="work">
            <h2 class="section__title section__title--work">My work</h2>
            <p class="section__subtitle section__subtitle--work">Selection of my work</p>

            <div class="portfolio">
                <a href="https://github.com/Marosko123/Marosko123/tree/main/Projects/StorageUnitAuction" target="_blank" class="portfolio__item">
                    <img src="@/assets/storageUnitAuction_picture.jpg" alt="storage unit auction" class="portfolio__img">
                </a>
                <a href="https://github.com/Marosko123/Marosko123/tree/main/Projects/DataStructures" target="_blank" class="portfolio__item">
                    <img src="@/assets/dataStructures_image.png" alt="data structures" class="portfolio__img">
                </a>
            </div>
        </section>

        <!-- Footer -->
        <footer>
            <a href="mailto:bednarmaros341@gmail.com" class="footer-link">bednarmaros341@gmail.com</a>
            <ul class="social-list">
                <li class="social-list__item"><a class="social-list__link" href="https://www.instagram.com/bednar.maros/" target="_blank"><img class="logo" src="@/assets/instagramLogo.png" alt="instagram logo"></a></li>
                <li class="social-list__item"><a class="social-list__link" href="https://www.linkedin.com/in/marosbednar/" target="_blank"><img class="logo" src="@/assets/linkedInLogo.png" alt="linkedin logo"></a></li>
                <li class="social-list__item"><a class="social-list__link" href="https://www.doucma.sk/272129-doucovanie-programovanie-je-hracka" target="_blank"><img class="logo" src="@/assets/doucmaLogo.png" alt="doucma logo"></a></li>
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