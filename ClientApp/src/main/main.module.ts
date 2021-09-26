import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { SecurityQuestionComponent } from './security-question/security-question.component';
import { MatInputModule } from '@angular/material/input';
import { MatButtonModule } from '@angular/material/button';
import { MatTable, MatTableModule } from '@angular/material/table';
import {MatSelectModule} from '@angular/material/select';
import { FormsModule, ReactiveFormsModule } from '@angular/forms';
import { AccountSummaryComponent } from './account-summary/account-summary.component';
import { TransactionHistoryComponent } from './transaction-history/transaction-history.component';
import { NewTransactionComponent } from './new-transaction/new-transaction.component';

@NgModule({
  declarations: [SecurityQuestionComponent, AccountSummaryComponent, TransactionHistoryComponent, NewTransactionComponent],
  imports: [
    CommonModule,
    MatInputModule,
    MatButtonModule,
    MatSelectModule,
    MatTableModule,
    FormsModule,
    ReactiveFormsModule,
  ],
})
export class MainModule {}
