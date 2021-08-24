
import { Component, OnInit } from '@angular/core';
import { ToastrService } from 'ngx-toastr';
import { EmployeesDetail } from '../shared/employees-detail.model';
import { EmployeesDetailService } from '../shared/employees-detail.service';

@Component({
  selector: 'app-employees-details',
  templateUrl: './employees-details.component.html',
  styles: [
  ]
})
export class EmployeesDetailsComponent implements OnInit {

  constructor(public service: EmployeesDetailService,
    private toastr: ToastrService) { }

  ngOnInit(): void {
    this.service.refreshList();
  }

  populateForm(selectedRecord: EmployeesDetail) {
    this.service.formData = Object.assign({}, selectedRecord);
  }

  onDelete(id: number) {
    if (confirm('Are you sure to delete this record?')) {
      this.service.deleteEmployeesDetail(id)
        .subscribe(
          res => {
            this.service.refreshList();
            this.toastr.error("Deleted successfully", 'Payment Detail Register');
          },
          err => { console.log(err) }
        )
    }
  }

}
