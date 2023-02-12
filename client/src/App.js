import React from 'react';
import { useContext } from 'react';
import { Provider } from 'react-redux';
import { Link } from 'react-router-dom';
import store from './app/store';
import Banner from './components/Banner';
import Category from './components/catergory';
import Content from './components/Content';
import Footer from './components/Footer';
import Header from './components/Header';
import Navbar from './components/Navbar/Navbar';
import SliderProduct from './components/Slider';
import { AuthContext } from './contexts/AuthProvider';


function App() {
  const { auth } = useContext(AuthContext);
  
  return (
    <>
      <>
        <div className='fixed left-0 top-[190px] z-[9999] w-[1650px] '>
          <div>
            <div className='absolute left-[115px] '>
              <img className='w-[150px] ' src="//theme.hstatic.net/1000026716/1000440777/14/stk-bn-left.png?v=31049" />
            </div>
            <div className='absolute right-[-140px] '>
              <img className='w-[150px] ' src="//theme.hstatic.net/1000026716/1000440777/14/stk-bn-right.png?v=31049" />
            </div>
          </div>
        </div>
        <header className="bg-[#f1f0f1]">
          <div className='bg-[url("https://theme.hstatic.net/1000026716/1000440777/14/bn-top2.jpg?v=30809")] bg-[#1c6c04] h-[50px] bg-no-repeat bg-center w-full  '></div>
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
        <div className='fixed right-[30px] bottom-[11px] '>
          <a target={"_blank"} href='https://www.facebook.com/your.firstname.lastname'>
            <img src="https://omnisales.worldfone.vn/portal/upload/livechat/logo/1664779722_G-bot-Finall-09--2-.png" />
          </a>
        </div>
      </>
    </>

  );
}

export default App;
