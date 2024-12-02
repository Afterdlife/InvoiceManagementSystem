import { ComponentFixture, TestBed } from '@angular/core/testing';

import { EditCustomerDialogsComponent } from './edit-customer-dialogs.component';

describe('EditCustomerDialogsComponent', () => {
  let component: EditCustomerDialogsComponent;
  let fixture: ComponentFixture<EditCustomerDialogsComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      imports: [EditCustomerDialogsComponent]
    })
    .compileComponents();

    fixture = TestBed.createComponent(EditCustomerDialogsComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
