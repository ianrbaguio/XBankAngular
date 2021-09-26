import { Component, OnInit } from '@angular/core';
import {Transaction} from '@libraries/data-access/general/src/lib/models/transaction';

const ELEMENT_DATA: Transaction[] = [
  {date: new Date(), description: 'Item Purchased', amount:-10.00, balance: 140.00},
  {date: new Date(), description: 'Item Purchased', amount:-10.00, balance: 130.00},
  {date: new Date(), description: 'Deposit', amount:20.00, balance: 150.00},

]

@Component({
  selector: 'app-transaction-history',
  templateUrl: './transaction-history.component.html',
  styleUrls: ['./transaction-history.component.scss']
})
export class TransactionHistoryComponent implements OnInit {

  displayedColumns: string[] = ['date', 'description', 'amount', 'balance'];
  dataSource = ELEMENT_DATA;

  constructor() { }

  ngOnInit(): void {
  }

}
