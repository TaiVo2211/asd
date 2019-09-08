import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { NgbModule } from '@ng-bootstrap/ng-bootstrap';
import { HttpClientModule } from '@angular/common/http';
import { NgSelectModule } from '@ng-select/ng-select';
import { FormsModule, ReactiveFormsModule } from '@angular/forms';
import { RouterModule, Routes } from '@angular/router';
import { AppRouting } from './app.router';
import { CommonModule } from '@angular/common';
import { SidebarModule } from 'ng-sidebar';

import { PerfectScrollbarModule } from 'ngx-perfect-scrollbar';
import { PERFECT_SCROLLBAR_CONFIG } from 'ngx-perfect-scrollbar';
import { PerfectScrollbarConfigInterface } from 'ngx-perfect-scrollbar';
import { ModalModule } from 'ngx-bootstrap';

import { BrowserAnimationsModule } from '@angular/platform-browser/animations';
import { BsDropdownModule } from 'ngx-bootstrap';
import { AlertModule } from 'ngx-alerts';
import { PlanbarComponent } from './plan-bar/plan-bar.component';
import { MainViewComponent } from './main-view/main-view.component';
import { NewsViewComponent } from './news-view/news-view.component';
import { HeaderComponent } from './header/header.component';
import { FooterComponent } from './footer/footer.component';
import { MoreTvNewsComponent } from './more-tv-news/more-tv-news.component';
import { ArticleComponent } from './article/article.component';
import { NewsSectionComponent } from './main-news/main-news.component';
import { SidenewsSectionComponent } from './side-news/side-news.component';
import { SidenewsHalfsizeComponent } from './side-news-half-size/side-news-half-size.component';
import { TimeMovieCinemaComponent } from './time-movie-cinema/time-movie-cinema.component';
import { PaymentSectionComponent } from './payment-section/payment-section.component';
import { OnlineMoviesCenterViewComponent } from './online-movies-center-view/online-movies-center-view.component';

const appRoutes: Routes = [
  {
    path: '**',
    redirectTo: ''
  }
];

const DEFAULT_PERFECT_SCROLLBAR_CONFIG: PerfectScrollbarConfigInterface = {
  suppressScrollX: true
};

export const environment = {
  production: false,
  appName: 'Lucifer'
};

@NgModule({
  declarations: [
    AppComponent,
    PlanbarComponent,
    MainViewComponent,
    NewsViewComponent,
    NewsSectionComponent,
    SidenewsSectionComponent,
    SidenewsHalfsizeComponent,
    HeaderComponent,
    FooterComponent,
    ArticleComponent,
    MoreTvNewsComponent,
    TimeMovieCinemaComponent,
    PaymentSectionComponent,
    OnlineMoviesCenterViewComponent,
  ],
  imports: [
    CommonModule,
    BrowserModule,
    AppRoutingModule,
    HttpClientModule,
    NgSelectModule,
    FormsModule,
    ModalModule.forRoot(),
    NgbModule.forRoot(),
    SidebarModule.forRoot(),
    BsDropdownModule.forRoot(),
    AppRouting,
    AppRoutingModule,
    PerfectScrollbarModule,
    BrowserAnimationsModule,
    ReactiveFormsModule,
    RouterModule.forRoot(appRoutes, {
      enableTracing: environment.production === false,
      useHash: true
    }),
    AlertModule.forRoot({maxMessages: 5, timeout: 5000, position: 'right'})
  ],
  entryComponents: [
  ],
  providers: [
    {
      provide: PERFECT_SCROLLBAR_CONFIG,
      useValue: DEFAULT_PERFECT_SCROLLBAR_CONFIG
    }
  ],
  bootstrap: [AppComponent]
})
export class AppModule { }
