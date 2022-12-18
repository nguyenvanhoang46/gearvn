import { useContext } from 'react';
import { Provider } from 'react-redux';
import './App.css';
import store from './app/store';
import Banner from './components/Banner';
import Category from './components/catergory';
import Content from './components/Content';
import Footer from './components/Footer';
import Header from './components/Header';
import SliderProduct from './components/Slider';
import { AuthContext } from './contexts/AuthProvider';


function App() {
  const {auth} = useContext(AuthContext);
  console.log(auth);

  return (
    <>
    <header className="bg-[#f1f0f1]">
    <div className=' bg-[url("https://theme.hstatic.net/1000026716/1000440777/14/bn-top2.jpg?v=30809")] bg-[#1c6c04] h-[50px] bg-no-repeat bg-center w-full  '></div>
      <Header />
      <div className=''>
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
    <div className='container mx-auto mt-20'>
      <Footer />
    </div>
  </>
  );
}

export default App;
