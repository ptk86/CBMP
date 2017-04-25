import { CBMP.ClientPage } from './app.po';

describe('cbmp.client App', () => {
  let page: CBMP.ClientPage;

  beforeEach(() => {
    page = new CBMP.ClientPage();
  });

  it('should display message saying app works', () => {
    page.navigateTo();
    expect(page.getParagraphText()).toEqual('cbmp works!');
  });
});
