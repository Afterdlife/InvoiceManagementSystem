import { Component, Inject } from "@angular/core";
import { MAT_DIALOG_DATA, MatDialogRef } from "@angular/material/dialog";
import { InvoiceService } from "../../services/invoice.service";

@Component({
  selector: "app-create-edit-invoice-dialog",
  templateUrl: "./create-edit-invoice-dialog.component.html",
  styleUrls: ["./create-edit-invoice-dialog.component.css"],
})
export class CreateEditInvoiceDialogComponent {
  invoice: any = {};
  customers = [];

  constructor(
    public dialogRef: MatDialogRef<CreateEditInvoiceDialogComponent>,
    @Inject(MAT_DIALOG_DATA) public data: any,
    private invoiceService: InvoiceService
  ) {
    this.invoice = data ? { ...data } : {};
    this.loadCustomers();
  }

  loadCustomers(): void {
    // Fetch all customers for dropdown
  }

  save(): void {
    if (this.data) {
      this.invoiceService
        .update(this.invoice)
        .subscribe(() => this.dialogRef.close(true));
    } else {
      this.invoiceService
        .create(this.invoice)
        .subscribe(() => this.dialogRef.close(true));
    }
  }
}
