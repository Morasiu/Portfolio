import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { PCGameComponent } from './pc-game.component';

describe('GameComponent', () => {
  let component: PCGameComponent;
  let fixture: ComponentFixture<PCGameComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ PCGameComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(PCGameComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
