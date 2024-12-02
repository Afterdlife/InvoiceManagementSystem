import { Component, OnInit } from "@angular/core";
import { ReceivableService } from "../services/receivable.service";

@Component({
  selector: "app-receivable-details",
  templateUrl: "./receivable-details.component.html",
  styleUrls: ["./receivable-details.component.css"],
})
export class ReceivableDetailsComponent implements OnInit {
  receivables = [];
  filterText = "";

  constructor(private receivableService: ReceivableService) {}

  ngOnInit(): void {
    this.getReceivables();
  }

  getReceivables(): void {
    this.receivableService.getAll(this.filterText).subscribe((result) => {
      this.receivables = result;
    });
  }
}
