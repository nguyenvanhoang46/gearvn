import React from 'react'
import InfoTop from '../Gearvninfotop'
import InputSearch from './InputSearch'
import HeaderRight from './HeaderRight'
import Logo from './Login'
import { Link } from 'react-router-dom';
import Category from '../catergory'
const Header = () => {
  return (
    <>
      <div className="bg-[#f1f0f1]">
        <div className="pt-2 pb-2 border-b-[1px] border-[red] border-[#d4d4d4]">
          <div className='container mx-auto'>
                  <div className="grid grid-cols-12 gap-4 ">
                  <div className="col-span-2">
                    <Link to='/gearvn'>
                        <Logo />               
                    </Link>
                  </div>
                  <div className="col-span-10">
                    <div className="flex items-center">
                      <InputSearch />
                      <HeaderRight />
                    </div>
                      <InfoTop />
                  </div>
              </div>
          </div>  
        </div>   
      </div>  
    </>
  )
}

export default Header
