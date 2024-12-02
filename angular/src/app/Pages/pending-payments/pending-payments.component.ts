import { Component, OnInit } from "@angular/core";
import { PaymentsService } from "../services/payments.service";

@Component({
  selector: "app-pending-payments",
  templateUrl: "./pending-payments.component.html",
  styleUrls: ["./pending-payments.component.css"],
})
export class PendingPaymentsComponent implements OnInit {
  pendingPayments = [];
  filterText = "";
  filterDate: string | null = null;

  constructor(private paymentsService: PaymentsService) {}

  ngOnInit(): void {
    this.getPendingPayments();
  }

  getPendingPayments(): void {
    this.paymentsService
      .getPendingPayments(this.filterText, this.filterDate)
      .subscribe((result) => {
        this.pendingPayments = result;
      });
  }

  markAsPaid(payment: any): void {
    this.paymentsService.markAsPaid(payment.id).subscribe(() => {
      this.getPendingPayments();
    });
  }
}
