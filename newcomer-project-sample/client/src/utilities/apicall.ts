import axios from "axios"

const newLocal = "https://localhost:7283/"

export const async post(path, data): Promise<any> {
   let result = await axios.post(newLocal+ path, {
        firstName: data.firstName,
        lastName: emp.lastName,
        adress: emp.adress,
        dateBirth: emp.dateBirth,
        dateEntry: emp.dateEntry,
        dateEnd: dateFormat,
        position: emp.position,
        flat: emp.flat,
    })
    return result.data;
    
}