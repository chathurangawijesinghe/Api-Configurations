import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';

@Injectable({
  providedIn: 'root'
})
export class OdataService {

  constructor(private http: HttpClient) { }

  getData() {
    return this.http.get('https://localhost:44386/odata/tests?$select=name,id');
  }
}
