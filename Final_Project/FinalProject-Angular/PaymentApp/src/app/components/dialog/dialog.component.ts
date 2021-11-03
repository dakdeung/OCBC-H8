import { Component, Inject, OnInit } from '@angular/core';
import {MatDialog, MatDialogRef, MAT_DIALOG_DATA} from '@angular/material/dialog';

@Component({
  selector: 'app-dialog',
  templateUrl: './dialog.component.html',
  styleUrls: ['./dialog.component.css']
})
export class DialogComponent implements OnInit {

  isDelete = false;
  message = ''
  action = ''
  constructor(public dialogRef: MatDialogRef<DialogComponent>,
    @Inject(MAT_DIALOG_DATA) public data: any) {}

  ngOnInit(): void {
    this.isDelete = this.data.isDelete;

    if(this.isDelete){
      this.message = "Are you sure want to delete " + this.data.Payment.cardOwnerName + "?"
      this.action = "Delete"

    }else{
      this.message = "Are you sure want to logout?"
      this.action = "Logout"
    }
  }

}
