import { Component, OnInit } from '@angular/core';
import {FormControl} from "@angular/forms";

@Component({
  selector: 'app-new-transaction',
  templateUrl: './new-transaction.component.html',
  styleUrls: ['./new-transaction.component.scss']
})
export class NewTransactionComponent implements OnInit {

  transactionType = new FormControl();
  account = new FormControl();
  amount = new FormControl();

  constructor() { }

  ngOnInit(): void {
  }

}
