import { createApp } from 'vue'
import axios from 'axios'
import VueAxios from 'vue-axios'
import  App from './App.vue'
import router from './router'
import "bootstrap/dist/css/bootstrap.min.css"
import "bootstrap"
import '@fortawesome/fontawesome-free/css/all.css'
import '@fortawesome/fontawesome-free/js/all.js'

createApp(App)
.use(router)
.use(VueAxios, axios)
.mount('#app')
