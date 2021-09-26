import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';
import { LoginComponent } from 'src/login/login/login.component';
import { SecurityQuestionComponent } from 'src/main/security-question/security-question.component';
import { AccountSummaryComponent } from 'src/main/account-summary/account-summary.component';
import { RegisterComponent } from 'src/register/register/register.component';
import { TransactionHistoryComponent } from 'src/main/transaction-history/transaction-history.component';
import {NewTransactionComponent} from 'src/main/new-transaction/new-transaction.component';

const routes: Routes = [
  { path: '', pathMatch: 'full', component: LoginComponent },
  { path: 'security-question', component: SecurityQuestionComponent },
  { path: 'account-summary', component: AccountSummaryComponent },
  { path: 'register', component: RegisterComponent },
  { path: 'transaction-history', component: TransactionHistoryComponent},
  { path: 'new-transaction', component: NewTransactionComponent}
];

@NgModule({
  imports: [RouterModule.forRoot(routes, { relativeLinkResolution: 'legacy' })],
  exports: [RouterModule],
})
export class AppRoutingModule {}
