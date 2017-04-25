import { browser, element, by } from 'protractor';

export class CBMP.ClientPage {
  navigateTo() {
    return browser.get('/');
  }

  getParagraphText() {
    return element(by.css('cbmp-root h1')).getText();
  }
}
