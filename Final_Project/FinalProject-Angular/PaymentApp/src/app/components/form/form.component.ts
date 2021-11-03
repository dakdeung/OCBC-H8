import { Component, EventEmitter, Input, OnInit, Output } from '@angular/core';
import { FormControl, FormGroup, Validators } from '@angular/forms';
import { Router } from '@angular/router';
import { Payment } from 'src/app/models/payment';
import { PaymentService } from 'src/app/services/payment.service';

@Component({
  selector: 'app-form',
  templateUrl: './form.component.html',
  styleUrls: ['./form.component.css']
})
export class FormComponent implements OnInit {

  isEdit = false
  id: any
  button = ''
  @Input() edit: any
  @Input() data: any
  @Output() changeEvent = new EventEmitter<any>();
  constructor(private paymentService: PaymentService, public router: Router) { }

  inputForm = new FormGroup({
    cardOwnerName: new FormControl('', [Validators.required, Validators.minLength(3)]),
    cardNumber: new FormControl('', [Validators.required, Validators.minLength(16),Validators.maxLength(16),Validators.pattern(/^[0-9]+$/)]),
    expirationDate: new FormControl('', [Validators.required,Validators.maxLength(5),Validators.pattern(/^[0-9/]+$/)]),
    securityCode: new FormControl('', [Validators.required, Validators.minLength(4), Validators.maxLength(4)])
  })

  get cardOwnerName() {
    return this.inputForm.get('cardOwnerName')
  }
  get cardNumber() {
    return this.inputForm.get('cardNumber')
  }
  get expirationDate() {
    return this.inputForm.get('expirationDate')
  }
  get securityCode() {
    return this.inputForm.get('securityCode')
  }

  ngOnInit(): void {
    if(this.isEdit){
      this.button = "Update"
    }else{
      this.button = "Save"
    }
  }

  ngDoCheck() {
    // console.log("INBI" +this.data);
    if (this.data != undefined) {
      console.log("CHECK FORM");
      this.inputForm.reset()
      if (this.data.isEdit) {
        console.log("CHECK FORM 2");
        this.isEdit = true;
        if(this.isEdit){
          this.button = "Update"
        }else{
          this.button = "Save"
        }
        console.log(this.data.paymentDetailId + "Data");

        this.id = this.data.paymentDetailId
          this.inputForm.patchValue({
            cardOwnerName: this.data.cardOwnerName,
            cardNumber: this.data.cardNumber,
            expirationDate: this.data.expirationDate,
            securityCode: this.data.securityCode,
          });
        this.edit = false
        this.data = null
      }
    }

  }

  onSubmit() {
    if (this.isEdit) {
      this.putPayment()
    } else {
      this.postPayment()
    }
  }

  postPayment() {
    this.paymentService.postPayment(this.inputForm.value).subscribe(
      (res) => {
        if (res) {
          alert("Data Berhasil Dibuat");
          this.inputForm.reset();
          this.changeEvent.emit(true);
        }
      },
      (err) => {
        alert(err);
      }
    );
  }

  putPayment() {
    const dataEdit: Payment =
    {
      paymentDetailId: this.id,
      cardOwnerName: this.inputForm.value.cardOwnerName,
      cardNumber: this.inputForm.value.cardNumber,
      expirationDate: this.inputForm.value.expirationDate,
      securityCode: this.inputForm.value.securityCode,
    }
    this.paymentService.putPayment(this.id, dataEdit).subscribe(
      (res) => {
        if (res.message) {
          alert(res.message);
          this.inputForm.reset();
          this.isEdit = false
          this.changeEvent.emit(true);
        }
      },
      (err) => {
        alert(err);
        this.inputForm.reset();
        this.isEdit = false
      }
    );
  }
}
