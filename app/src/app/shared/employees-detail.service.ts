import { EmployeesDetail } from './employees-detail.model';
import { Injectable } from '@angular/core';
import { HttpClient } from "@angular/common/http";
@Injectable({
  providedIn: 'root'
})
export class EmployeesDetailService {

  constructor(private http: HttpClient) { }

  readonly baseURL = 'https://localhost:5001/api/EmployeesDetails'
  formData: EmployeesDetail= new EmployeesDetail();
  list: EmployeesDetail[] = [];

  postEmployeesDetail() {
    return this.http.post(this.baseURL, this.formData);
  }
  putEmployeesDetail() {
    return this.http.put(`${this.baseURL}/${this.formData.EmployeesDetailId}`, this.formData);
  }
  deleteEmployeesDetail(id: number) {
    return this.http.delete(`${this.baseURL}/${id}`);
  }

  refreshList() {
    this.http.get(this.baseURL)
      .toPromise()
      .then(res =>this.list = res as EmployeesDetail[]);
  }
}
