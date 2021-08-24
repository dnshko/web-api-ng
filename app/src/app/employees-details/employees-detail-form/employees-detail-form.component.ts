import { Component, OnInit } from '@angular/core';
import { NgForm } from '@angular/forms';

import { EmployeesDetail } from 'src/app/shared/employees-detail.model';
import { EmployeesDetailService } from 'src/app/shared/employees-detail.service';
import { ToastrService } from 'ngx-toastr';

@Component({
  selector: 'app-employees-detail-form',
  templateUrl: './employees-detail-form.component.html',
  styles: [
  ]
})
export class EmployeesDetailFormComponent implements OnInit {

  constructor(public service: EmployeesDetailService,
    private toastr: ToastrService) { }

  ngOnInit(): void {
  }

  onSubmit(form: NgForm) {
    if (this.service.formData.EmployeesDetailId == 0)
      this.insertRecord(form);
    else
      this.updateRecord(form);
  }

  insertRecord(form: NgForm) {
    this.service.postEmployeesDetail().subscribe(
      res => {
        this.resetForm(form);
        this.service.refreshList();
        this.toastr.success('Submitted successfully', 'Payment Detail Register')
      },
      err => { console.log(err); }
    );
  }

  updateRecord(form: NgForm) {
    this.service.putEmployeesDetail().subscribe(
      res => {
        this.resetForm(form);
        this.service.refreshList();
        this.toastr.info('Updated successfully', 'Payment Detail Register')
      },
      err => { console.log(err); }
    );
  }


  resetForm(form: NgForm) {
    form.form.reset();
    this.service.formData = new EmployeesDetail();
  }
}
