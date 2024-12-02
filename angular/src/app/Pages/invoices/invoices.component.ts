import { Component, OnInit } from "@angular/core";
import { InvoiceService } from "../services/invoice.service";
import { CreateEditInvoiceDialogComponent } from "./create-edit-invoice-dialog/create-edit-invoice-dialog.component";
import { MatDialog } from "@angular/material/dialog";

@Component({
  selector: "app-invoices",
  templateUrl: "./invoices.component.html",
  styleUrls: ["./invoices.component.css"],
})
export class InvoicesComponent implements OnInit {
  invoices = [];
  filterText = "";

  constructor(
    private invoiceService: InvoiceService,
    private dialog: MatDialog
  ) {}

  ngOnInit(): void {
    this.getInvoices();
  }

  getInvoices(): void {
    this.invoiceService.getAll(this.filterText).subscribe((result) => {
      this.invoices = result;
    });
  }

  openCreateDialog(): void {
    const dialogRef = this.dialog.open(CreateEditInvoiceDialogComponent, {
      width: "500px",
      data: null,
    });

    dialogRef.afterClosed().subscribe((result) => {
      if (result) {
        this.getInvoices();
      }
    });
  }

  openEditDialog(invoice): void {
    const dialogRef = this.dialog.open(CreateEditInvoiceDialogComponent, {
      width: "500px",
      data: invoice,
    });

    dialogRef.afterClosed().subscribe((result) => {
      if (result) {
        this.getInvoices();
      }
    });
  }

  deleteInvoice(invoice): void {
    if (confirm("Are you sure to delete this invoice?")) {
      this.invoiceService.delete(invoice.invoiceID).subscribe(() => {
        this.getInvoices();
      });
    }
  }
}
