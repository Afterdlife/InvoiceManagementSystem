import { Component, OnInit } from "@angular/core";
import { SalesService } from "../services/sales.service";

@Component({
  selector: "app-sales-by-customer",
  templateUrl: "./sales-by-customer.component.html",
  styleUrls: ["./sales-by-customer.component.css"],
})
export class SalesByCustomerComponent implements OnInit {
  salesRecords = [];
  filterText = "";

  constructor(private salesService: SalesService) {}

  ngOnInit(): void {
    this.getSales();
  }

  getSales(): void {
    this.salesService.getAll(this.filterText).subscribe((result) => {
      this.salesRecords = result;
    });
  }
}
