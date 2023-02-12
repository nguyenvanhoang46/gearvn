import React from 'react'
import { AiFillFacebook } from 'react-icons/ai';
import { BsYoutube } from 'react-icons/bs';
import { HiUserGroup } from 'react-icons/hi';
import { ImQrcode } from 'react-icons/im';
import { GiBanknote } from 'react-icons/gi';
import { CiMoneyCheck1 } from 'react-icons/ci';
import { TbBuildingBank } from 'react-icons/tb';

import "./footer.css";

const FooterB = () => {
    return (

        <footer className=' mt-10'>
            <div className="grid grid-cols-5">
                <div className="">
                    <ul className="">
                        <h2 className='text-[15px] font-bold mb-[10px] '>Hỗ trợ khách hàng</h2>
                        <li><a className='text-[13px] pt-[0.365rem] pr-[0.75rem] text-[#333333] hover:text-[#024dbc] ' href="">Thẻ ưu đãi</a> </li>
                        <li><a className='text-[13px] pt-[0.365rem] pr-[0.75rem] text-[#333333] hover:text-[#024dbc] ' href="">Trung tâm bảo hành</a> </li>
                        <li><a className='text-[13px] pt-[0.365rem] pr-[0.75rem] text-[#333333] hover:text-[#024dbc] ' href="">Thanh toán và giao hàng</a> </li>
                        <li><a className='text-[13px] pt-[0.365rem] pr-[0.75rem] text-[#333333] hover:text-[#024dbc] ' href="">Dịch vụ sữa chữa và bảo trì</a> </li>
                        <li><a className='text-[13px] pt-[0.365rem] pr-[0.75rem] text-[#333333] hover:text-[#024dbc] ' href="">Doanh nghiệp thân thiết</a></li>
                    </ul>
                </div>
                <div className="">
                    <ul className=''>
                        <h2 className='text-[15px] font-bold mb-[10px]' >Chính sách Mua hàng và Bảo hành</h2>
                        <li><a className='text-[13px] pt-[0.365rem] pr-[0.75rem] text-[#333333] hover:text-[#024dbc]  ' href="">Quy định chung</a></li>
                        <li><a className='text-[13px] pt-[0.365rem] pr-[0.75rem] text-[#333333] hover:text-[#024dbc]  ' href="">Chính sách Bảo mật thông tin</a></li>
                        <li><a className='text-[13px] pt-[0.365rem] pr-[0.75rem] text-[#333333] hover:text-[#024dbc]  ' href="">Chính sách Vận chuyển</a></li>
                        <li><a className='text-[13px] pt-[0.365rem] pr-[0.75rem] text-[#333333] hover:text-[#024dbc]  ' href="">Chính sách bảo hành</a></li>
                        <li><a className='text-[13px] pt-[0.365rem] pr-[0.75rem] text-[#333333] hover:text-[#024dbc]  ' href="">Chính sách đổi trả và hoàn tiền</a></li>
                        <li><a className='text-[13px] pt-[0.365rem] pr-[0.75rem] text-[#333333] hover:text-[#024dbc]  ' href="">Quy định giá cả</a></li>
                        <li><a className='text-[13px] pt-[0.365rem] pr-[0.75rem] text-[#333333] hover:text-[#024dbc]  ' href="">Chính sách trả góp</a></li>
                    </ul>
                </div>
                <div className="">
                    <ul className=''>
                        <h2 className='text-[15px] font-bold mb-[10px]' >Thông tin Gearvn</h2>
                        <li><a className='text-[13px] pt-[0.365rem] pr-[0.75rem] text-[#333333] hover:text-[#024dbc] ' href="">Giới thiệu Gearvn</a></li>
                        <li><a className='text-[13px] pt-[0.365rem] pr-[0.75rem] text-[#333333] hover:text-[#024dbc] ' href="">Thông tin Gearvn</a></li>
                        <li><a className='text-[13px] pt-[0.365rem] pr-[0.75rem] text-[#333333] hover:text-[#024dbc] ' href="">Hệ thống Showroom</a></li>
                        <li><a className='text-[13px] pt-[0.365rem] pr-[0.75rem] text-[#333333] hover:text-[#024dbc] ' href="">Hỏi đáp</a></li>
                        <li><a className='text-[13px] pt-[0.365rem] pr-[0.75rem] text-[#333333] hover:text-[#024dbc] ' href="">Tin công nghệ</a></li>
                        <li><a className='text-[13px] pt-[0.365rem] pr-[0.75rem] text-[#333333] hover:text-[#024dbc] ' href="">Tuyển dụng</a></li>
                    </ul>
                </div>
                <div className="">
                    <ul className=''>
                        <h2 className='text-[15px] font-bold mb-[10px]' >Cộng động Gearvn</h2>
                        <li><div className='text-[13px] pt-[0.365rem] pr-[0.75rem] text-[#333333] '> Gọi mua hàng <a className='text-[#0D6EFD] ' href="">18006867</a> </div></li>
                        <li><div className='text-[13px] pt-[0.365rem] pr-[0.75rem] text-[#333333] '> Gọi mua hàng <a className='text-[#0D6EFD] ' href="">18006867</a> </div></li>
                        <li><a className='text-[13px] pt-[0.365rem] pr-[0.75rem] text-[#333333] hover:text-[#024dbc] flex items-center gap-1' href=""><AiFillFacebook className='text-[#485992] text-[17px] ' /> Gearvn Việt Nam</a></li>
                        <li><a className='text-[13px] pt-[0.365rem] pr-[0.75rem] text-[#333333] hover:text-[#024dbc] flex items-center gap-1' href=""><BsYoutube className='text-[#cf2200] text-[17px] ' /> Gearvn Media</a></li>
                        <li><a className='text-[13px] pt-[0.365rem] pr-[0.75rem] text-[#333333] hover:text-[#024dbc] flex items-center gap-1' href=""><HiUserGroup className='text-[#00AFF7] text-[17px]  ' /> Gearvn Media</a></li>
                    </ul>
                </div>
                <div className="">
                    <ul className=''>
                        <h2 className='text-[15px] font-bold mb-[10px]' >Email liên hệ</h2>
                        <li>
                            <h3 className='text-[13px] pt-[0.365rem] pr-[0.75rem]'>Hỗ trợ khách hàng</h3>
                            <a className='text-[13px] pt-[0.365rem] pr-[0.75rem] text-[#0D6EFD] ' href="">cskk@gearvn.vn</a>
                        </li>
                        <li>
                            <h3 className='text-[13px] pt-[0.365rem] pr-[0.75rem]'>Liên hệ báo giá</h3>
                            <a className='text-[13px] pt-[0.365rem] pr-[0.75rem] text-[#0D6EFD] ' href="">baogia@gearvn.vn</a>
                        </li>
                        <li>
                            <h3 className='text-[13px] pt-[0.365rem] pr-[0.75rem]'>Hợp tác phát triển</h3>
                            <a className='text-[13px] pt-[0.365rem] pr-[0.75rem] text-[#0D6EFD] ' href="">hoptac@gearvn.vn</a>
                        </li>
                    </ul>
                </div>
            </div>
            <div className="flex mt-7">
                <div className="w-[30%] ">
                    <div className='text-[15px] font-bold'>Phương thức thanh toán</div>
                    <div className="flex ">
                        <a href='' className="payment">
                            <ImQrcode className='text-[25px] ' />
                            <span className='pay-chu'>QR Code</span>
                        </a>
                        <a href='' className="payment">
                            <GiBanknote className='text-[25px] ' />
                            <span className='pay-chu'>Tiền mặt</span>
                        </a>
                        <a href='' className="payment">
                            <TbBuildingBank className='text-[25px] ' />
                            <span className='pay-chu'> Trả góp</span>
                        </a>
                        <a href='' className="payment">
                            <CiMoneyCheck1 className='text-[25px] ' />
                            <span className='pay-chu'> Internet <br />Banking</span>
                        </a>
                    </div>
                </div>
                <div className=''>
                    <div className='text-[15px] font-bold '>Danh sách các ngân hàng thanh toán online</div>
                    <img className='mt-3' src="https://shopfront-cdn.tekoapis.com/static/vnpay_banks.png" alt="" />
                </div>
            </div>

        </footer>
    )
}

export default FooterB