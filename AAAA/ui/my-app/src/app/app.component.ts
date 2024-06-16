import { Component, inject } from '@angular/core';
import { RouterOutlet } from '@angular/router';
import { CatFactsService } from './services/cat-facts.service';
import { CommonModule } from '@angular/common';
import { HttpClientModule } from '@angular/common/http';

@Component({
  selector: 'app-root',
  standalone: true,
  imports: [RouterOutlet, CommonModule, HttpClientModule],
  templateUrl: './app.component.html',
  styleUrl: './app.component.css'
})
export class AppComponent {
  title = 'adasdadas';
  private catFactsService = inject(CatFactsService);
  catFacts: any = [];
  constructor() {
    this.catFactsService.getCatFacts().subscribe((facts) => this.catFacts = facts);
  }
  
  cardClick(){
    if(confirm('¿Querés falopa?')){
      console.log('YESSSSS');
    }else{
      console.log('NOSSSSSSS');
    }
  }

}
