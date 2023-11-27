
using LinkedList;

Page pageFirst = new Page() { Content = "Atualmente..." };
Page pageSecond = new Page() { Content = "Aplicação..." };
Page pageThird = new Page() { Content = "Muito de..." };
Page pageFourth = new Page() { Content = "Voce sabia", PageNumber = 4};

Page pageFifth = new Page() { 
    Content = "Enquanto..." ,
    PageNumber = 5;
    };

Page pageSixth = new Page() { Content = "Voce poderia..."};
pageSixth.PageNumber = 6;

var PageSeventh = new Page();
PageSeventh.Content = "Era uma vez...";;
PageSeventh.PageNUmber = 7;

LinkedList<Page> pages = new LinkedList<Page>();
pages.AddLast(pageSecond);
LInkedListNode<Page> nodePageFourth = pages.AddLast(pageFourth);
pages.AddLast(pageSixth);
pages.AddFirst(pageFirst);

pages.AddBefore(nodePageFourth, pageThird);
pages.AddAfter(nodePageFourth, pageFifth);

// Atividade pratica: livro pg 73

LinkedListNode<Page> current = pages.First;
