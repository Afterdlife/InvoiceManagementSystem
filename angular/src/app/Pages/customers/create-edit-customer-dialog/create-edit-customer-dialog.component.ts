import { Component, Inject } from "@angular/core";
import { MAT_DIALOG_DATA, MatDialogRef } from "@angular/material/dialog";
import { CustomerService } from "../../services/customer.service";

@Component({
  selector: "app-create-edit-customer-dialog",
  templateUrl: "./create-edit-customer-dialog.component.html",
  styleUrls: ["./create-edit-customer-dialog.component.css"],
})
export class CreateEditCustomerDialogComponent {
  customer: any = {};

  constructor(
    public dialogRef: MatDialogRef<CreateEditCustomerDialogComponent>,
    @Inject(MAT_DIALOG_DATA) public data: any,
    private customerService: CustomerService
  ) {
    this.customer = data ? { ...data } : {};
  }

  save(): void {
    if (this.data) {
      this.customerService
        .update(this.customer)
        .subscribe(() => this.dialogRef.close(true));
    } else {
      this.customerService
        .create(this.customer)
        .subscribe(() => this.dialogRef.close(true));
    }
  }
}
