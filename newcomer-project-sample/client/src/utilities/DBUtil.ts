import axios from "axios";
import { Employee } from "../models/Employee";
import { Position } from "../models/Position";
import { PreviousEmployee } from "../models/PreviousEmployee";

const newLocal = "https://localhost:7283/newwebapi/"

export default class DBUtil{
    public DBUtil(){}
    
    static async getEmployees(){
        return await axios.get(newLocal + "Employee");
    }
    
    static async getPositions(){
        return await axios.get(newLocal + "Positions");
    }

    static async getPreviousEmployees(){
        return await axios.get(newLocal + "PreviousEmployees");
    }
    
    static async getEmployee(id: number){
        return await axios.get(newLocal + "Employee/" + id)
    }

    static async getPosition(id: number){
        return await axios.get(newLocal + "Positions/" + id)
    }

    static async getPreviousEmployee(id: number){
        return await axios.get(newLocal + "PreviousPositions/" + id)
    }

    static async postEmployee(employee: Employee){
        return await axios.post(newLocal + "Employee", {
                id: employee.id,
                firstName: employee.firstName,
                lastName: employee.lastName,
                adress: employee.adress,
                dateBirth: employee.dateBirth,
                dateEntry: employee.dateEntry,
                position: employee.position,
                flat: employee.flat.toString(),
        })
    }

    static async postPosition(position: Position){
        return await axios.post(newLocal + "Positions", {
            positionName: position.positionName,
            numberOfEmployeesOnPos: 0
        })
    }

    static async postPreviousEmployee(previousEmployee: PreviousEmployee){
        return await axios.post(newLocal + "PreviousEmployees", {
            firstName: previousEmployee.firstName,
            lastName: previousEmployee.lastName,
            adress: previousEmployee.adress,
            dateBirth: previousEmployee.dateBirth,
            dateEntry: previousEmployee.dateEntry,
            dateEnd: previousEmployee.dateEnd,
            position: previousEmployee.position,
            flat: previousEmployee.flat,
        })
    }
    
    static async putEmployee(employee: Employee){
        return await axios.put(newLocal + "Employee", {
                id: employee.id,
                firstName: employee.firstName,
                lastName: employee.lastName,
                adress: employee.adress,
                dateBirth: employee.dateBirth,
                dateEntry: employee.dateEntry,
                position: employee.position,
                flat: employee.flat.toString(),
        })
    }

    static async putPosition(position: Position){
        return await axios.put(newLocal + "Positions", {
            id: position.id,
            positionName: position.positionName,
            numberOfEmployeesOnPos: position.numberOfEmployeesOnPos
        })
    }

    static async putPreviousEmployee(previousEmployee: PreviousEmployee){
        return await axios.put(newLocal + "PreviousEmployees", {
            id: previousEmployee.id,
            firstName: previousEmployee.firstName,
            lastName: previousEmployee.lastName,
            adress: previousEmployee.adress,
            dateBirth: previousEmployee.dateBirth,
            dateEntry: previousEmployee.dateEntry,
            dateEnd: previousEmployee.dateEnd,
            position: previousEmployee.position,
            flat: previousEmployee.flat,
        })
    }
    
    static async deleteEmployee(id: number){
        return await axios.delete(newLocal + "Employee/" + id)
    }

    static async deletePosition(id: number){
        return await axios.delete(newLocal + "Positions/" + id)
    }

    static async deletePreviousEmployee(id: number){
        return await axios.delete(newLocal + "PreviousEmployees/" + id)
    }
}