import React from 'react'
import Header from '../Header'
import {Link} from 'react-router-dom'
import {FaUser} from 'react-icons/fa'
import {MdEmail} from 'react-icons/md'
import {BsTelephoneFill} from 'react-icons/bs'
import {RiLockPasswordFill} from 'react-icons/ri'
import Category from '../catergory'
import Footer from '../Footer'
const Login = () => {
  return (
    <>
    <div className='bg-[#f1f0f1]'>
     <Header />  
     <Category />
     </div>
   <div className="container mx-auto text-center mt-10">
     <h1 className='text-[36px] font-medium '>Đăng nhập</h1>
     <div className="mt-5 flex text-center justify-center">
       <form className='' action="" method="">
         <div className="flex">
             <span className='py-[10px] px-[15px] text-[14px]  text-[#555] bg-[#eee] border-[#ccc] rounded border-[1px] rounded-tr-[0px] rounded-br-[0px] border-r-0 border-t[0px] '>
             <MdEmail />
             </span>
            <input className='w-[270px] py-[17px] px-[15px] text-[14px]  text-[#555] border-[#ccc] rounded-tl-[0px] rounded-bl-[0px] focus:outline rounded border-[1px] h-[34px] focus:shadow focus:outline-[#66afe9]  ' type="email" placeholder='Email' />
         </div>
         <div className="flex  mt-5">
             <span className='py-[10px] px-[15px] text-[14px]  text-[#555] bg-[#eee] border-[#ccc] rounded border-[1px] rounded-tr-[0px] rounded-br-[0px] border-r-0 border-t[0px] '>
             <RiLockPasswordFill />
             </span>
           <input className='w-[270px] py-[17px] px-[15px] text-[14px]  text-[#555] border-[#ccc] rounded-tl-[0px] rounded-bl-[0px] focus:outline rounded border-[1px] h-[34px] focus:shadow focus:outline-[#66afe9]  ' type="password" placeholder='Password' />
         </div>
       </form>
     </div>
     <div className="mt-7">
      <input className='hover:bg-[black] bg-[#F0F0F0] uppercase hover:text-[white] cursor-pointer py-[7px] px-[14px] text-[14px] font-normal border-[1px] rounded-[4px] ' type="submit" value="Đăng nhập" />			
     </div>
     <div className='mt-4'>
				<Link to='/' className='text-[#428bca] hover:text-[#f45b4f]'>Quên mật khẩu? </Link>
				hoặc <Link to='/register' className='text-[#428bca] hover:text-[#f45b4f]' href="/register" title="Đăng ký">Đăng ký</Link>
			</div>
     <div className="mt-10">
       <Footer />
     </div>
   </div>
   </>
  )
}

export default Login