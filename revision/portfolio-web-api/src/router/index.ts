import { createRouter, createWebHistory } from 'vue-router'
import Home  from "@/views/Home.vue"
import ProjectStorageUnitAuction  from "@/views/ProjectStorageUnitAuction.vue"
import ProjectDataStructures  from "@/views/ProjectDataStructures.vue"

const router = createRouter({
  history: createWebHistory(import.meta.env.BASE_URL),
  routes: [
    { path: '/', name: 'home', component: Home, props: true },
    { path: '/projectStorageUnitAuction', name: 'projectStorageUnitAuction', component: ProjectStorageUnitAuction, props: true },
    { path: '/projectDataStructures', name: 'projectDataStructures', component: ProjectDataStructures, props: true },
  ]
})

export default router
