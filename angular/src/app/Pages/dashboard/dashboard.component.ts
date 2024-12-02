import { Component, OnInit } from "@angular/core";
import { DashboardService } from "../services/dashboard.service";

@Component({
  selector: "app-dashboard",
  templateUrl: "./dashboard.component.html",
  styleUrls: ["./dashboard.component.css"],
})
export class DashboardComponent implements OnInit {
  totalCustomers = 0;
  totalInvoices = 0;
  salesChartData: any;
  invoiceStatusData: any;

  constructor(private dashboardService: DashboardService) {}

  ngOnInit(): void {
    this.getDashboardData();
  }

  getDashboardData(): void {
    this.dashboardService.getMetrics().subscribe((data) => {
      this.totalCustomers = data.totalCustomers;
      this.totalInvoices = data.totalInvoices;

      this.salesChartData = {
        labels: data.salesByMonth.map((s) => s.month),
        datasets: [
          {
            label: "Sales",
            data: data.salesByMonth.map((s) => s.total),
          },
        ],
      };

      this.invoiceStatusData = {
        labels: ["Paid", "Pending", "Overdue"],
        datasets: [
          {
            data: [
              data.paidInvoices,
              data.pendingInvoices,
              data.overdueInvoices,
            ],
          },
        ],
      };
    });
  }

  getTopCustomers(): void {
    this.salesService.getTopCustomers().subscribe((result) => {
      this.chartData = {
        labels: result.map((customer) => customer.name),
        datasets: [
          {
            label: "Total Sales",
            data: result.map((customer) => customer.totalSales),
            backgroundColor: "#42A5F5",
          },
        ],
      };
    });
  }

  getOverdueInvoices(): void {
    this.invoiceService.getOverdueInvoices().subscribe((result) => {
      this.overdueInvoices = result;
    });
  }

  sendReminder(invoice: any): void {
    this.invoiceService.sendReminder(invoice.id).subscribe(() => {
      alert("Reminder sent successfully.");
    });
  }
}
