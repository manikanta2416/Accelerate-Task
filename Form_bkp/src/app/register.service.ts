import { Injectable } from '@angular/core';
import { HttpClient, HttpHeaders } from '@angular/common/http';
import { Observable } from 'rxjs';
import { IRegisterUser } from './Interface/RegisterInterface';
@Injectable({
  providedIn: 'root'
})
export class RegisterService {

  constructor(private http: HttpClient) { }
  Regsiter(data: any): Observable<boolean> {
    return this.http.post<boolean>(`https://localhost:44382/api/Register/addRequest`, data);
  }
  ViewRequest(): Observable<IRegisterUser[]> {
    return this.http.get<IRegisterUser[]>(`https://localhost:44382/api/Register/getRequest`);
  }
}
