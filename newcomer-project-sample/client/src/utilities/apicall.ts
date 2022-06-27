import axios from "axios"

const newLocal = "https://localhost:7283/"

export const async:any, post: Promise<any> (path: string, data: any) {
   let result = await axios.post(newLocal+ path, {
        firstName: data.firstName,
        lastName: data.lastName,
        adress: data.adress,
        dateBirth: data.dateBirth,
        dateEntry: data.dateEntry,
        position: data.position,
        flat: data.flat,
    })
    return result.data;
    
}
