import { Component, OnInit } from "@angular/core";
import { DialogService } from "primeng/dynamicdialog";
import { CreateCustomerDialogComponent } from "../dialogs/create-customer-dialog/create-customer-dialog.component";
import { EditCustomerDialogComponent } from "../dialogs/edit-customer-dialog/edit-customer-dialog.component";

@Component({
  selector: "app-customers",
  standalone: true,
  imports: [],
  templateUrl: "./customers.component.html",
  styleUrl: "./customers.component.css",
})
export class CustomersComponent {
  customers = [
    {
      name: "John Doe",
      address: "123 Main St",
      email: "john@example.com",
      phone: "123-456-7890",
    },
  ];

  constructor(private dialogService: DialogService) {}

  ngOnInit(): void {}

  showCreateDialog(): void {
    const ref = this.dialogService.open(CreateCustomerDialogComponent, {
      header: "Create Customer",
      width: "50%",
    });

    ref.onClose.subscribe((result) => {
      if (result) {
        this.customers.push(result);
      }
    });
  }

  showEditDialog(customer: any): void {
    const ref = this.dialogService.open(EditCustomerDialogComponent, {
      header: "Edit Customer",
      width: "50%",
      data: customer,
    });

    ref.onClose.subscribe((result) => {
      if (result) {
        const index = this.customers.findIndex((c) => c.name === customer.name);
        if (index !== -1) {
          this.customers[index] = result;
        }
      }
    });
  }

  deleteCustomer(customer: any): void {
    this.customers = this.customers.filter((c) => c !== customer);
  }
}
