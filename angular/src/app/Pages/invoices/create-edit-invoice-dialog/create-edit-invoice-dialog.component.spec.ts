import { ComponentFixture, TestBed } from '@angular/core/testing';

import { CreateEditInvoiceDialogComponent } from './create-edit-invoice-dialog.component';

describe('CreateEditInvoiceDialogComponent', () => {
  let component: CreateEditInvoiceDialogComponent;
  let fixture: ComponentFixture<CreateEditInvoiceDialogComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      imports: [CreateEditInvoiceDialogComponent]
    })
    .compileComponents();

    fixture = TestBed.createComponent(CreateEditInvoiceDialogComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
