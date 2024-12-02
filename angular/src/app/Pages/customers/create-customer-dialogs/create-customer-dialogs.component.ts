import { Component, OnInit } from "@angular/core";
import { FormBuilder, FormGroup, Validators } from "@angular/forms";
import { DynamicDialogRef } from "primeng/dynamicdialog";

@Component({
  selector: "app-create-customer-dialogs",
  templateUrl: "./create-customer-dialogs.component.html",
})
export class CreateCustomerDialogsComponent implements OnInit {
  form: FormGroup;

  constructor(private fb: FormBuilder, public ref: DynamicDialogRef) {}

  ngOnInit(): void {
    this.form = this.fb.group({
      name: ["", Validators.required],
      address: ["", Validators.required],
      email: ["", [Validators.required, Validators.email]],
      phone: ["", Validators.required],
    });
  }

  createCustomer(): void {
    if (this.form.valid) {
      this.ref.close(this.form.value);
    }
  }

  closeDialog(): void {
    this.ref.close();
  }
}
