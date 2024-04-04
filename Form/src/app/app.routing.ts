import { RouterModule, Routes } from "@angular/router";
import { ModuleWithProviders } from "@angular/core";
import { HomeComponent } from "./home/home.component";
import { RegisterFormComponent } from "./register-form/register-form.component";
import { AboutComponent } from "./about/about.component";
import { NgModule } from '@angular/core';
import { ViewRequestComponent } from "./view-request/view-request.component";
const routes: Routes = [
  { path: 'home', component: HomeComponent },
  { path: 'register', component: RegisterFormComponent },
  { path: '', component: HomeComponent },
/*  { path: '**', component: HomeComponent },
*/  { path: 'about', component: AboutComponent },
  { path: 'viewrequest', component: ViewRequestComponent }
];
export const routing: ModuleWithProviders<RouterModule> = RouterModule.forRoot(routes);
