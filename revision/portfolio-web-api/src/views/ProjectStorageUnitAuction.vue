<template id="projectStorageUnitAuction">
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
                <strong>Storage unit auction</strong>
            </h1>
            <p class="section__subtitle section__subtitle--intro">Created using Java and MySQL 👨‍💻╰(*°▽°*)╯</p>
            <img src="@/assets/storageUnitAuction_picture.jpg" alt="A picture of the storage unit auction" class="intro__img">
        </section>

        <!-- About auction -->
        <section class="about-me about-auction" id="about">
            <h2 class="section__title section__title--about">What is it about</h2>
            <p class="section__subtitle section__subtitle--about">Buying and selling storage units for profit</p>

            <div class="about-me__body">
                <p>
                    Selling
                </p>
                <br>
                <p>
                    Buying
                </p>
                <br>
                <p>
                    Winning
                </p>
            </div>

            <img src="@/assets/storageUnitAuction_picture.jpg" alt="Storage unit auction" class="about-me__img">
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
    name: 'projectStorageUnitAuction',
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

.about-auction {
    background-image: url("../assets/laptop.jpg");
    background-size: cover;
    background-blend-mode: multiply;
    background-color: var(--clr-dark);
}

</style>