import './App.css';
import Banner from './components/Banner';
import Category from './components/catergory';
import Content from './components/Content';
import Footer from './components/Footer';
import Header from './components/Header';
import SliderProduct from './components/Slider';


function App() {
  return (
    <>
      <header className="bg-[#f1f0f1]">
        <div className="pt-2 pb-2 border-b-[1px] border-[red] border-[#d4d4d4]">
            <Header />
        </div>
        <div className='container mx-auto'>
          <Category />
        </div>
        <div className='container mx-auto'>
          <SliderProduct />
          <div className="mb-7">
            <Banner />
          </div>
        </div>
      </header>
      <div className='container mx-auto'>
        <Content />
      </div>
      <div className='container mx-auto'>
        <Footer />
      </div>
      {/* <Demo /> */}
    </>
  );
}

export default App;
