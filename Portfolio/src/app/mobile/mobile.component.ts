import { Component, OnInit, Input } from '@angular/core';

@Component({
  selector: 'app-mobile',
  templateUrl: './mobile.component.html',
  styleUrls: ['./mobile.component.less']
})
export class MobileComponent {
  @Input() name:string;
  @Input() image_src: string;
  @Input() short_description: string;
}
