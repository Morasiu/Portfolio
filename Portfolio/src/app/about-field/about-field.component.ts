import { Component, OnInit, Input } from '@angular/core';

@Component({
  selector: 'app-about-field',
  templateUrl: './about-field.component.html',
  styleUrls: ['./about-field.component.less']
})
export class AboutFieldComponent implements OnInit {

  @Input() logo: string;
  @Input() title: string;
  @Input() time: string;
  @Input() description: string;

  constructor() { }

  ngOnInit() {
  }

}
