import { createRouter, createWebHistory } from 'vue-router'
import Home  from "@/views/Home.vue"
import About  from "@/views/About.vue"
import Collection  from "@/views/Collection.vue"

const router = createRouter({
  history: createWebHistory(import.meta.env.BASE_URL),
  routes: [
    { path: '/', name: 'home', component: Home, props: true },
    { path: '/about', name: 'about', component: About, props: true },
    { path: '/collection', name: 'collection', component: Collection, props: true },
  ]
})

export default router
