import { Component, OnInit } from '@angular/core';
import { Payment } from 'src/app/models/payment';

@Component({
  selector: 'app-dashboard',
  templateUrl: './dashboard.component.html',
  styleUrls: ['./dashboard.component.css']
})
export class DashboardComponent implements OnInit {

  isChange: boolean = false
  isEdit: boolean = false
  data: any
  constructor() { }

  ngOnInit(): void {
  }

  changeEvent(change:boolean){
    this.isChange = change;

  }

  itemEvent(payment: Payment, bool: boolean){
    console.log("UBAH2" + payment.cardOwnerName);
    this.data = payment;
    console.log(payment.paymentDetailId);

    this.isEdit = bool;
  }

}
