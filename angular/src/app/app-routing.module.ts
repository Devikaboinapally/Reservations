import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { AddComponent } from './login/add/add.component';
import { LoginComponent } from './login/login.component';
import { ResComponent } from './res/res.component';

const routes: Routes = [{
  path: "", component: LoginComponent
},

{
  path: 'Res', component: ResComponent
},
]

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
