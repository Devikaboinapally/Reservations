import { HttpClient, HttpHeaders } from "@angular/common/http";
import { Injectable } from "@angular/core";
@Injectable({
    providedIn : 'root'
})
export class DataService{
    httpOptions = {
        headers:new HttpHeaders({
            'Content-Type': 'application/json',
        }),
    };
    constructor(private http:HttpClient){}
    getData(){
        return this.http.get("https://localhost:44301/api/res/GetResDetails")
    }

    addData(data: any) {
        return this.http.post("https://localhost:44301/api/res/InsertResDetails", data,this.httpOptions).subscribe();
    }
    deleteData(data:number) {
        return this.http.delete("https://localhost:44301/api/res/DeleteResDetails/"+data, this.httpOptions).subscribe();
    }
}
