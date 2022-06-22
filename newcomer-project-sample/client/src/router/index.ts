import { createRouter, createWebHistory } from 'vue-router'
import ActualEmployees from '@/views/ActualEmployees.vue'
import PreviousEmployees from '@/views/PreviousEmployees.vue'
import Positions from '@/views/Positions.vue'
import EmployeeInfo from '@/views/EmployeeInfo.vue'
import AddNewEmployee from '@/views/AddNewEmployee.vue'
import EditEmployee from '@/views/EditEmployee.vue'

// defines all needed routes 
const routes = [
    {path: '/', name: 'ActualEmployees', component: ActualEmployees, props: true},
    {path: '/PreviousEmployees', name: 'PreviousEmployees', component: PreviousEmployees, props: true},
    {path: '/Positions', name: 'Positions', component: Positions, props: true},
    // {path: '/EmployeeInfo', name: 'EmployeeInfo', component: EmployeeInfo, props: true},
    {path: '/AddNewEmployee', name: 'AddNewEmployee', component: AddNewEmployee, props: true},
    {path: '/EditEmployee', name: 'EditEmployee', component: EditEmployee, props: true},
    {path: '/EmployeeInfo', name: 'EmployeeInfo', component: EmployeeInfo, props: true},
]

const router = createRouter({
    history: createWebHistory(),
    routes
})

export default router