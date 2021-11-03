import { Component, OnInit } from '@angular/core';
import { Router } from '@angular/router';
import { Payment } from 'src/app/models/payment';
import { PaymentService } from 'src/app/services/payment.service';

@Component({
  selector: 'app-table',
  templateUrl: './table.component.html',
  styleUrls: ['./table.component.css']
})
export class TableComponent implements OnInit {

  heads: string[] = ['Payment Id', 'Nama', 'Card Number', 'Card', 'Expired Date', 'Security Code']
  constructor(private paymentService: PaymentService, public router: Router) { }

  payment: Payment[]=[];
  ngOnInit(): void {
    this.getPayment()
  }

  getPayment(){
    // this.paymentService.getPayment().subscribe(response => this.payment = response);
    this.paymentService
    .getPayment()
    .subscribe((res: any) => {
      if(res) this.payment = res
    })
  }

  // this.payment.putPayment(this.updobj, result.id).subscribe(x => location.reload())


}
